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
using IFSP.ADS.SiPDV.SharedMemory;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormLogin : Form
    {
        #region -Private Attributes-

        private OperatorBusiness operatorBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();

            this.operatorBusiness = new OperatorBusiness();
        }

        #endregion

        #region -Events-

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

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

        /// <summary>
        /// Limpa os campos do formulário.
        /// </summary>
        private void ClearForm()
        {
            this.textBoxOperator.Focus();
            this.textBoxOperator.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
        }

        /// <summary>
        /// Ação de Login.
        /// Caso o login seja realizado com sucesso, joga o usuário logado na 'SharedMemory'.
        /// </summary>
        private void Login()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (string.IsNullOrWhiteSpace(this.textBoxOperator.Text) ||
                    string.IsNullOrWhiteSpace(this.textBoxPassword.Text))
                {
                    MessageBox.Show(this, Resources.LoginEmptyFields, Resources.Warning, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Operator oper = new Operator();
                oper.Code = this.textBoxOperator.Text;
                oper.Password = this.textBoxPassword.Text;

                // Verifica se o login é válido.
                oper.Id = this.operatorBusiness.Login(oper);

                // Se id > 0, então login efetuado com sucesso.
                if (oper.Id > 0)
                {
                    SharedData.Instance.OperatorData = this.operatorBusiness.OperatorById(oper.Id);

                    ClearForm();

                    this.Hide();

                    FormMain frmMain = new FormMain();
                    frmMain.Show(this);
                }
                else
                {
                    MessageBox.Show(this, Resources.LoginFailed, Resources.Error, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.LoginError, Resources.Error, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion
    }
}
