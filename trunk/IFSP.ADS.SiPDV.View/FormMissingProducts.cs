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

        private void LoadReport()
        {
            try
            {
                MissingProductsDataSet dataSet = new MissingProductsDataSet();
                dataSet.Tables[DatabaseConstants.ProductTable].Rows.Clear();

                foreach (DataRow dr in this.productBusiness.GetProductsStockMissing().Rows)
                {
                    dataSet.Tables[DatabaseConstants.ProductTable].Rows.Add(dr.ItemArray);
                }

                MissingProductsCrystalReport crystalReport = new MissingProductsCrystalReport();
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
