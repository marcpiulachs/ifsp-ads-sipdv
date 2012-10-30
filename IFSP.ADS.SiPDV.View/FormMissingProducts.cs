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
using IFSP.ADS.SiPDV.Reports.StockReports;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormMissingProducts : Form
    {
        #region -Private Attributes-

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormMissingProducts()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormMissingProducts_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Carrega o relatório de produtos em falta no estoque.
        /// </summary>
        private void LoadReport()
        {
            try
            {
                // Cria o DataSet que armazena os dados para o relatório.
                MissingProductsDataSet dataSet = new MissingProductsDataSet();

                // Limpa o DataTable de produtos.
                dataSet.Tables[DatabaseConstants.ProductTable].Rows.Clear();

                // Preenche o DataTable de produtos com o resultado da busca feita no banco de dados.
                foreach (DataRow dr in this.productBusiness.GetProductsStockMissing().Rows)
                {
                    dataSet.Tables[DatabaseConstants.ProductTable].Rows.Add(dr.ItemArray);
                }

                // Cria o CrystalReport de produtos em falta no estoque.
                MissingProductsCrystalReport crystalReport = new MissingProductsCrystalReport();

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
