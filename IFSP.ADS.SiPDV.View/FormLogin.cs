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

        private void textBoxOperator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #region -Private Methods-

        private void Login()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxOperator.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBoxPassword.Text))
                {
                    Operator oper = new Operator();
                    oper.Code = this.textBoxOperator.Text;
                    oper.Password = this.textBoxPassword.Text;

                    if (this.operatorBusiness.Login(oper) > 0)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, Resources.OperatorLoginError, Resources.Error, MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, Resources.OperatorLoginWarning, Resources.Warning, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.OperatorLoginWarning, Resources.Warning, MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
            }
        }

        #endregion
    }
}
