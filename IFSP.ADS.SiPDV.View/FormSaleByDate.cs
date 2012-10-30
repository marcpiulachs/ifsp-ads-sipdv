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
using IFSP.ADS.SiPDV.Reports.SaleReports;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormSaleByDate : Form
    {
        #region -Private Attributes-

        private SaleBusiness saleBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormSaleByDate()
        {
            InitializeComponent();

            this.saleBusiness = new SaleBusiness();
        }

        #endregion

        #region -Events-

        private void FormSaleByDate_Load(object sender, EventArgs e)
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
        /// Carrega o relatório de vendas por período.
        /// </summary>
        private void LoadReport()
        {
            try
            {
                // Pega o DateTime inicial e final para geração do relatório.
                DateTime dtInitial = this.dateTimePickerInitial.Value.Date;
                DateTime dtFinal = this.dateTimePickerFinal.Value.Date;

                // Cria o DataSet que armazena os dados para o relatório.
                SaleByDateDataSet dataSet = new SaleByDateDataSet();

                // Limpa o DataTable de venda.
                dataSet.Tables[DatabaseConstants.SaleTable].Rows.Clear();

                // Preenche o DataTable de venda com o resultado da busca feita no banco de dados.
                foreach (DataRow dr in this.saleBusiness.GetSaleByDate(dtInitial, dtFinal).Rows)
                {
                    dataSet.Tables[DatabaseConstants.SaleTable].Rows.Add(dr.ItemArray);
                }

                // Cria o CrystalReport de vendas por período.
                SaleByDateCrystalReport crystalReport = new SaleByDateCrystalReport();
                
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
