using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IFSP.ADS.SiPDV.SharedMemory;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormMain : Form
    {
        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region -Events-

        private void FormMain_Load(object sender, EventArgs e)
        {
            ShowOperator();
            VerifyUserAccess();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(this, Resources.CloseProgramQuestion, Resources.Question,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                    MessageBoxDefaultButton.Button2))
            {
                CloseMain();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.saleToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                this.tablesToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                this.productsToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                this.operatorsToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.stockToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                this.reportsToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F7)
            {
                this.configurationToolStripMenuItem.PerformClick();
            }
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormSale frmSale = new FormSale();
                frmSale.MdiParent = this;
                frmSale.Show();
            }
            catch (Exception)
            { }
        }

        private void tablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormTables frmTables = new FormTables();
                frmTables.MdiParent = this;
                frmTables.Show();
            }
            catch (Exception)
            { }
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormProducts frmProducts = new FormProducts();
                frmProducts.MdiParent = this;
                frmProducts.Show();
            }
            catch (Exception)
            { }
        }

        private void operatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormOperator frmOperators = new FormOperator();
                frmOperators.MdiParent = this;
                frmOperators.Show();
            }
            catch (Exception)
            { }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormStock frmStock = new FormStock();
                frmStock.MdiParent = this;
                frmStock.Show();
            }
            catch (Exception)
            { }
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saleByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormSaleByDate frmSaleByDate = new FormSaleByDate();
                frmSaleByDate.MdiParent = this;
                frmSaleByDate.Show();
            }
            catch (Exception)
            { }
        }

        private void soldProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormSoldProducts frmSoldProducts = new FormSoldProducts();
                frmSoldProducts.MdiParent = this;
                frmSoldProducts.Show();
            }
            catch (Exception)
            { }
        }

        private void missingProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormMissingProducts frmMissingProducts = new FormMissingProducts();
                frmMissingProducts.MdiParent = this;
                frmMissingProducts.Show();
            }
            catch (Exception)
            { }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormConfiguration frmConfiguration = new FormConfiguration();
                frmConfiguration.MdiParent = this;
                frmConfiguration.Show();
            }
            catch (Exception)
            { }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            this.toolStripStatusLabelDateValue.Text = dateTime.ToString("dd/MM/yyyy");
            this.toolStripStatusLabelHourValue.Text = dateTime.ToString("HH:mm:ss");
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Exibe o operador logado na barra inferior de informações.
        /// </summary>
        private void ShowOperator()
        {
            try
            {
                // Verifica se há um operador na SharedMemory.
                if (SharedData.Instance.OperatorData != null)
                {
                    this.toolStripStatusLabelOperatorValue.Text = SharedData.Instance.OperatorData.Name;
                }
                else
                {
                    CloseMain();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Verifica os acessos do usuário logado.
        /// Caso não seja usuário admin, esconde as opções de Operadores, Relatórios e Configurações.
        /// </summary>
        private void VerifyUserAccess()
        {
            try
            {
                if (SharedData.Instance.OperatorData.Code != "admin")
                {
                    this.operatorsToolStripMenuItem.Visible = false;
                    this.reportsToolStripMenuItem.Visible = false;
                    this.configurationToolStripMenuItem.Visible = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Limpa a SharedMemory e volta ao login.
        /// </summary>
        private void CloseMain()
        {
            try
            {
                SharedData.Instance.Clear();

                this.Hide();
                this.Owner.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
