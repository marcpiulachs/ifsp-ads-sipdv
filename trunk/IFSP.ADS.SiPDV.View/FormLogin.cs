using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IFSP.ADS.SiPDV.Business;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //TestBus t = new TestBus();
            //t.GetConnectionString();

            this.Close();
        }
    }
}
