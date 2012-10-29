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

        private void LoadReport()
        {
            try
            {
                DateTime dtInitial = this.dateTimePickerInitial.Value.Date;
                DateTime dtFinal = this.dateTimePickerFinal.Value.Date;

                SaleByDateDataSet dataSet = new SaleByDateDataSet();
                dataSet.Tables[DatabaseConstants.SaleTable].Rows.Clear();

                foreach (DataRow dr in this.saleBusiness.GetSaleByDate(dtInitial, dtFinal).Rows)
                {
                    dataSet.Tables[DatabaseConstants.SaleTable].Rows.Add(dr.ItemArray);
                }

                SaleByDateCrystalReport crystalReport = new SaleByDateCrystalReport();
                crystalReport.SetDataSource(dataSet);

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
