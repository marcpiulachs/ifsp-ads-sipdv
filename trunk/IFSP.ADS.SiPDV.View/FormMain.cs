using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormMain : Form
    {
        #region -Constructor-

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region -Events-

        private void FormMain_Load(object sender, EventArgs e)
        {

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
                this.stockToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                this.reportsToolStripMenuItem.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
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

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            this.toolStripStatusLabelDateValue.Text = dateTime.ToString("dd/MM/yyyy");
            this.toolStripStatusLabelHourValue.Text = dateTime.ToString("HH:mm:ss");
        }

        #endregion
    }
}
