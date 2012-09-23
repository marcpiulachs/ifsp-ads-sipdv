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

        private FormAddProduct frmAddProduct;
        private FormConfirmSale frmConfirmSale;

        private Product currentProduct;
        private List<Product> lstProduct;

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        public FormSale()
        {
            InitializeComponent();

            this.frmAddProduct = new FormAddProduct();
            this.frmAddProduct.AddProduct += new FormAddProduct.AddProductEventHandler(frmAddProduct_AddProduct);

            this.lstProduct = new List<Product>();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormSale_Load(object sender, EventArgs e)
        {
            InitializeListBox();
            CountItemsAndCalculateSubtotal();
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
                CountItemsAndCalculateSubtotal();

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
            e.Graphics.DrawString(listBoxProducts.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);

            // Se o ListBox tem foco, desenha o foco no ListBoxItem selecionado.
            e.DrawFocusRectangle();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            this.frmAddProduct.ShowDialog(this);
        }

        private void frmAddProduct_AddProduct(Product product)
        {
            this.textBoxBarCode.Text = product.BarCode.ToString();
            
            AddProduct();
            CountItemsAndCalculateSubtotal();

            this.textBoxBarCode.Text = string.Empty;
            this.textBoxBarCode.Focus();
        }

        private void buttonConfirmSale_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmConfirmSale = new FormConfirmSale(this.lstProduct);
                frmConfirmSale.ShowDialog(this);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region -Private Methods-

        private void InitializeListBox()
        {
            this.listBoxProducts.Items.Clear();
            this.listBoxProducts.Items.Add(LIST_BOX_HEADER);
        }

        private int GetProductIndex(Product product)
        {
            try
            {
                for (int i = 0; i < this.lstProduct.Count; i++)
                {
                    if (this.lstProduct[i].Id == product.Id)
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
                    this.currentProduct.Quantity = int.Parse(textBoxQuantity.Text);

                    productIndex = GetProductIndex(this.currentProduct);

                    // Se o índice do produto for maior que 0 ele já está na lista, caso contrário ele será adicionado.
                    if (productIndex > -1)
                    {
                        this.currentProduct.Quantity += this.lstProduct[productIndex].Quantity;

                        this.lstProduct[productIndex] = this.currentProduct;
                        this.listBoxProducts.Items[productIndex + 1] = this.currentProduct;
                    }
                    else
                    {
                        this.lstProduct.Add(this.currentProduct);
                        this.listBoxProducts.Items.Add(this.currentProduct);
                    }

                    this.textBoxName.Text = this.currentProduct.Name;
                    this.textBoxPrice.Text = this.currentProduct.SalePrice.ToString("0.00");
                    this.textBoxSubtotal.Text = this.currentProduct.CalculateSubtotal().ToString("0.00");
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

        private void CountItemsAndCalculateSubtotal()
        {
            float subtotal = 0.0F;

            try
            {
                foreach (Product product in this.lstProduct)
                {
                    subtotal += product.CalculateSubtotal();
                }

                this.textBoxItems.Text = this.lstProduct.Count.ToString();
                this.textBoxTotal.Text = "R$" + subtotal.ToString("0.00");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
