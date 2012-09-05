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
    public partial class FormSplash : Form
    {
        #region -Constructor-

        public FormSplash()
        {
            InitializeComponent();
        }

        #endregion

        #region -Events-

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.progressBar.Value >= 100)
            {
                this.Close();
            }

            this.progressBar.PerformStep();
        }

        #endregion
    }
}
