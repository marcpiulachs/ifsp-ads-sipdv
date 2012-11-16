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
    public partial class FormConfirmSale : Form
    {
        #region -Private Attributes-

        private float subtotal = 0.0F;
        private float discount = 0.0F;
        private float total = 0.0F;

        private List<Product> lstProducts;

        private SaleBusiness saleBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        /// <param name="lstProducts">Lista de produtos que será vendida</param>
        public FormConfirmSale(List<Product> lstProducts)
        {
            InitializeComponent();

            this.lstProducts = lstProducts;

            this.saleBusiness = new SaleBusiness();

            CalculateSubtotal();
        }

        #endregion

        #region -Event Handling-

        /// <summary>
        /// Delegate para declaração do evento de venda confirmada.
        /// </summary>
        public delegate void ConfirmedSaleEventHandler();

        /// <summary>
        /// Evento para informar que a venda foi confirmada.
        /// </summary>
        public event ConfirmedSaleEventHandler ConfirmedSale;

        /// <summary>
        /// Lança evento de venda confirmada.
        /// </summary>
        public void ThrowConfirmSale()
        {
            ConfirmedSaleEventHandler handler = ConfirmedSale;

            if (handler != null)
            {
                ConfirmedSale();
            }
        }

        #endregion

        #region -Events-

        private void textBoxDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateTotal();
            }
        }

        private void textBoxDiscount_Leave(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void buttonConfirmSale_Click(object sender, EventArgs e)
        {
            ConfirmSale();
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Calcula o subtotal da venda.
        /// </summary>
        private void CalculateSubtotal()
        {
            try
            {
                foreach (Product product in this.lstProducts)
                {
                    this.subtotal += product.CalculateSubtotal();
                }

                this.textBoxSubtotal.Text = this.subtotal.ToString("0.00");
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        /// <summary>
        /// Calcula o total da venda (Total = Subtotal - Desconto).
        /// </summary>
        private void CalculateTotal()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxDiscount.Text))
                {
                    this.discount = float.Parse(this.textBoxDiscount.Text);
                }

                if (this.discount >= 0 && this.discount <= this.subtotal)
                {
                    this.total = this.subtotal - this.discount;
                    this.textBoxTotal.Text = this.total.ToString("0.00");
                }
                else
                {
                    this.textBoxDiscount.Text = string.Empty;
                    this.textBoxDiscount.Focus();
                }
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        /// <summary>
        /// Confirma a realização da venda.
        /// </summary>
        private void ConfirmSale()
        {
            try
            {
                CalculateTotal();

                Sale sale = new Sale();
                sale.OperatorId = SharedData.Instance.OperatorData.Id;
                sale.DateTime = DateTime.Now;
                sale.Subtotal = this.subtotal;
                sale.Discount = this.discount;
                sale.Total = this.total;

                this.saleBusiness.InsertSale(sale, lstProducts);

                MessageBox.Show(this, Resources.SaleSaveSuccess, Resources.Success, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                ThrowConfirmSale();

                this.Close();
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        #endregion
    }
}
