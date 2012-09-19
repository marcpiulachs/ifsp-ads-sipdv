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
    public partial class FormSale : Form
    {
        #region -Constants-

        private const string LIST_BOX_HEADER = "CÓDIGO        NOME                 QTD   PREÇO  SUBTOT";

        #endregion

        #region -Private Attributes-

        private Product currentProduct;
        private ProductListItem currentProductListItem;
        private List<ProductListItem> lstProductListItem;

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        public FormSale()
        {
            InitializeComponent();

            this.lstProductListItem = new List<ProductListItem>();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormSale_Load(object sender, EventArgs e)
        {
            InitializeListBox();
            CountItemsAndCalculateTotal();
            this.textBoxBarCode.Focus();
        }

        private void textBoxQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxBarCode.Focus();
            }
        }

        private void textBoxBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddProduct();
                CountItemsAndCalculateTotal();

                this.textBoxBarCode.Text = string.Empty;
                this.textBoxBarCode.Focus();
            }
        }

        private void listBoxProducts_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Desenha o background do ListBox para cada ListBoxItem.
            e.DrawBackground();

            // Preenche o ListBoxItem com cinza caso for par, e com branco caso for ímpar.
            e.Graphics.FillRectangle(e.Index % 2 == 0 ? Brushes.LightGray : Brushes.White, e.Bounds);

            // Desenha o escrito do ListBoxItem.
            if (listBoxProducts.Items[e.Index].ToString() == LIST_BOX_HEADER)
            {
                e.Graphics.DrawString(listBoxProducts.Items[e.Index].ToString(), new Font(e.Font, FontStyle.Bold), 
                                      Brushes.Black, e.Bounds);
            }
            else
            {
                e.Graphics.DrawString(listBoxProducts.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);
            }

            // Se o ListBox tem foco, desenha o foco no ListBoxItem selecionado.
            e.DrawFocusRectangle();
        }

        #endregion

        #region -Private Methods-

        private void InitializeListBox()
        {
            this.listBoxProducts.Items.Clear();
            this.listBoxProducts.Items.Add(LIST_BOX_HEADER);
        }

        private int GetProductIndex(ProductListItem productListItem)
        {
            try
            {
                for (int i = 0; i < this.lstProductListItem.Count; i++)
                {
                    if (this.lstProductListItem[i].Id == productListItem.Id)
                    {
                        return i;
                    }
                }

                return -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AddProduct()
        {
            int productIndex;

            try
            {
                this.currentProduct = this.productBusiness.GetProductByBarCode(long.Parse(this.textBoxBarCode.Text));

                if (this.currentProduct != null)
                {
                    this.currentProductListItem = new ProductListItem(this.currentProduct, int.Parse(this.textBoxQuantity.Text));

                    productIndex = GetProductIndex(this.currentProductListItem);

                    // Se o índice do produto for maior que 0 ele já está na lista, caso contrário ele será adicionado.
                    if (productIndex > -1)
                    {
                        this.currentProductListItem.Quantity += this.lstProductListItem[productIndex].Quantity;
                        this.currentProductListItem.CalculateSubtotal();

                        this.lstProductListItem[productIndex] = this.currentProductListItem;
                        this.listBoxProducts.Items[productIndex + 1] = this.currentProductListItem;
                    }
                    else
                    {
                        this.lstProductListItem.Add(this.currentProductListItem);
                        this.listBoxProducts.Items.Add(this.currentProductListItem);
                    }

                    this.textBoxName.Text = this.currentProductListItem.Name;
                    this.textBoxPrice.Text = this.currentProductListItem.Price.ToString("0.00");
                    this.textBoxSubtotal.Text = this.currentProductListItem.Subtotal.ToString("0.00");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CountItemsAndCalculateTotal()
        {
            float total = 0.0F;

            try
            {
                foreach (ProductListItem p in this.lstProductListItem)
                {
                    total += p.Subtotal;
                }

                this.textBoxItems.Text = this.lstProductListItem.Count.ToString();
                this.textBoxTotal.Text = "R$" + total.ToString("0.00");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
