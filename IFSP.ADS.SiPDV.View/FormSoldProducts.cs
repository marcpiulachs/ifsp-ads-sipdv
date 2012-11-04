using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using IFSP.ADS.SiPDV.Business;
using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;
using IFSP.ADS.SiPDV.Reports.ProductReports;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormSoldProducts : Form
    {
        #region -Private Attributes-

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormSoldProducts()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormSoldProducts_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void buttonLoadReport_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Carrega o relatório de produtos vendidos.
        /// </summary>
        private void LoadReport()
        {
            DataTable dtProducts;

            try
            {
                // Verifica se o tipo do relatório é de mais vendidos ou de menos vendidos.
                bool isBestSellers = this.radioButtonBestSellers.Checked;

                // Pega o DateTime inicial e final para geração do relatório.
                DateTime dtInitial = this.dateTimePickerInitial.Value.Date;
                DateTime dtFinal = this.dateTimePickerFinal.Value.Date.Add(new TimeSpan(23, 59, 59));

                // Verifica qual o tipo de relatório para buscar os dados.
                if (isBestSellers)
                {
                    dtProducts = this.productBusiness.GetProductsBestSellers(dtInitial, dtFinal);
                }
                else
                {
                    dtProducts = this.productBusiness.GetProductsWorstSellers(dtInitial, dtFinal);
                }

                // Cria o DataSet que armazena os dados para o relatório.
                SoldProductsDataSet dataSet = new SoldProductsDataSet();

                // Limpa o DataTable de produtos.
                dataSet.Tables[DatabaseConstants.ProductTable].Rows.Clear();

                // Preenche o DataTable de produtos vendidos com o resultado da busca feita no banco de dados.
                foreach (DataRow dr in dtProducts.Rows)
                {
                    dataSet.Tables[DatabaseConstants.ProductTable].Rows.Add(dr.ItemArray);
                }

                // Cria o CrystalReport de produtos vendidos.
                SoldProductsCrystalReport crystalReport = new SoldProductsCrystalReport();

                // Define que a fonte de dados do relatório é o DataSet.
                crystalReport.SetDataSource(dataSet);

                // Exibe o relatório no componente visual do CrystalReport.
                this.crystalReportViewer.ReportSource = crystalReport;
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.ProductSaveError, Resources.Error,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
