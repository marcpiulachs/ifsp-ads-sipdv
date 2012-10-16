using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using IFSP.ADS.SiPDV.Business;
using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormStock : Form
    {
        #region -Private Attributes-

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormStock()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormStock_Load(object sender, EventArgs e)
        {
            LoadAllProductsStock();
        }

        private void textBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveStock();
            LoadAllProductsStock();
        }

        private void textBoxSearchBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchBarCode.Text))
                {
                    LoadProductsStockByBarCode(this.textBoxSearchBarCode.Text);
                }
            }
        }

        private void textBoxSearchBarCode_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchBarCode.Text.Length == 0)
            {
                LoadAllProductsStock();
            }
        }

        private void textBoxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
                {
                    LoadProductsStockByName(this.textBoxSearchName.Text);
                }
            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchName.Text.Length == 0)
            {
                LoadAllProductsStock();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxSearchBarCode.Text))
            {
                LoadProductsStockByBarCode(this.textBoxSearchBarCode.Text);
            }
            else if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
            {
                LoadProductsStockByName(this.textBoxSearchName.Text);
            }
            else
            {
                LoadAllProductsStock();
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            FillFields();
        }

        #endregion

        #region -Private Methods-

        private void ClearFields()
        {
            this.textBoxBarCode.Text = string.Empty;
            this.textBoxName.Text = string.Empty;
            this.textBoxDescription.Text = string.Empty;
            this.textBoxQuantity.Text = string.Empty;
            this.textBoxQuantity.Focus();
        }

        private void FillFields()
        {
            if (this.dataGridViewProducts.SelectedRows.Count == 1)
            {
                this.textBoxBarCode.Text = this.dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
                this.textBoxName.Text = this.dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
                this.textBoxDescription.Text = this.dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void LoadAllProductsStock()
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetAllProductsStock();
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        private void LoadProductsStockByBarCode(string barCode)
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetProductStockByBarCode(long.Parse(barCode));
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        private void LoadProductsStockByName(string name)
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetProductsStockByName(name);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        private void SaveStock()
        {
            int currentQuantity;
            int additionalQuantity;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                Thread.Sleep(1000);

                if (this.dataGridViewProducts.SelectedRows.Count == 1)
                {
                    currentQuantity = int.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString());
                    additionalQuantity = int.Parse(textBoxQuantity.Text);

                    Product product = new Product();
                    product.Id = int.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());
                    product.BarCode = long.Parse(this.textBoxBarCode.Text);
                    product.Name = this.textBoxName.Text;
                    product.Description = this.textBoxDescription.Text;

                    if (this.radioButtonProductIn.Checked)
                    {
                        product.Quantity = currentQuantity + additionalQuantity;
                    }
                    else
                    {
                        product.Quantity = currentQuantity - additionalQuantity;
                    }

                    this.productBusiness.UpdateProductQuantity(product);

                    MessageBox.Show(this, "", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion
    }
}
