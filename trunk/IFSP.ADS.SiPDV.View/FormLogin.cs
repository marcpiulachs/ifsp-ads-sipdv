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
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormLogin : Form
    {
        #region -Private Attributes-

        private OperatorBusiness operatorBusiness;

        #endregion

        #region -Constructor-

        public FormLogin()
        {
            InitializeComponent();

            this.operatorBusiness = new OperatorBusiness();
        }

        #endregion

        #region -Events-

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxOperator.Text) && !string.IsNullOrWhiteSpace(this.textBoxPassword.Text))
            {
                if (Login())
                {
                    this.Close();
                }
            }
            else
            {

            }
        }

        #endregion

        #region -Private Methods-

        private bool Login()
        {
            try
            {


                return true;
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                return false;
            }
        }

        #endregion
    }
}
