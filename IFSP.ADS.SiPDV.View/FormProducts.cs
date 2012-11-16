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
    public partial class FormProducts : Form
    {
        #region -Private Attributes-

        ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormProducts()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void textBoxBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.textBoxName.Focus();
            }
        }

        private void textBoxBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBoxCostPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != ',' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && e.KeyChar != ',' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.dataGridViewProducts.ClearSelection();
            this.textBoxBarCode.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveProduct();
            LoadAllProducts();
        }

        private void textBoxSearchBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchBarCode.Text))
                {
                    LoadProductsByBarCode(this.textBoxSearchBarCode.Text);
                }
            }
        }

        private void textBoxSearchBarCode_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchBarCode.Text.Length == 0)
            {
                LoadAllProducts();
            }
        }

        private void textBoxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
                {
                    LoadProductsByName(this.textBoxSearchName.Text);
                }
            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchName.Text.Length == 0)
            {
                LoadAllProducts();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxSearchBarCode.Text))
            {
                LoadProductsByBarCode(this.textBoxSearchBarCode.Text);
            }
            else if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
            {
                LoadProductsByName(this.textBoxSearchName.Text);
            }
            else
            {
                LoadAllProducts();
            }
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            ClearFields();
            FillFields();
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Limpa os campos do formulário de produtos.
        /// </summary>
        private void ClearFields()
        {
            this.textBoxBarCode.Text = string.Empty;
            this.textBoxName.Text = string.Empty;
            this.textBoxDescription.Text = string.Empty;
            this.comboBoxMeasurementUnity.SelectedIndex = -1;
            this.textBoxCostPrice.Text = string.Empty;
            this.textBoxSalePrice.Text = string.Empty;
            this.radioButtonActive.Checked = true;
        }

        /// <summary>
        /// Preenche os campos do formulário de produtos com os dados do produto selecionado.
        /// </summary>
        private void FillFields()
        {
            if (this.dataGridViewProducts.SelectedRows.Count == 1)
            {
                this.textBoxBarCode.Text = this.dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
                this.textBoxName.Text = this.dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
                this.textBoxDescription.Text = this.dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
                this.comboBoxMeasurementUnity.SelectedItem = this.dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
                this.textBoxCostPrice.Text = this.dataGridViewProducts.SelectedRows[0].Cells[5].Value.ToString();
                this.textBoxSalePrice.Text = this.dataGridViewProducts.SelectedRows[0].Cells[6].Value.ToString();
                if (this.dataGridViewProducts.SelectedRows[0].Cells[7].Value.ToString() == true.ToString())
                {
                    this.radioButtonActive.Checked = true;
                }
                else
                {
                    this.radioButtonInactive.Checked = true;
                }
            }
        }

        /// <summary>
        /// Carrega todos os produtos.
        /// </summary>
        private void LoadAllProducts()
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetAllProducts();
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
        /// Carrega o produto pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        private void LoadProductsByBarCode(string barCode)
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetProductByBarCode(long.Parse(barCode));
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
        /// Carrega os produtos pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        private void LoadProductsByName(string name)
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetProductsByName(name);
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
        /// Salva os dados do produto.
        /// </summary>
        private void SaveProduct()
        {
            try
            {
                // Verifica se os campos do formulário não estão vazios.
                if (string.IsNullOrWhiteSpace(this.textBoxBarCode.Text) ||
                    string.IsNullOrWhiteSpace(this.textBoxName.Text) ||
                    string.IsNullOrWhiteSpace(this.textBoxDescription.Text) ||
                    string.IsNullOrWhiteSpace(this.comboBoxMeasurementUnity.SelectedItem.ToString()) ||
                    string.IsNullOrWhiteSpace(this.textBoxCostPrice.Text) ||
                    string.IsNullOrWhiteSpace(this.textBoxSalePrice.Text))
                {
                    MessageBox.Show(this, Resources.ProductSaveEmptyFields, Resources.Warning, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

                Product product = new Product();

                if (this.dataGridViewProducts.SelectedRows.Count == 1)
                {
                    product.Id = int.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());
                }
                product.BarCode = long.Parse(this.textBoxBarCode.Text);
                product.Name = this.textBoxName.Text;
                product.Description = this.textBoxDescription.Text;
                product.MeasurementUnit = this.comboBoxMeasurementUnity.SelectedItem.ToString();
                product.StockQuantity = 0;
                product.Status = this.radioButtonActive.Checked ? 1 : 0;
                product.CostPrice = float.Parse(this.textBoxCostPrice.Text);
                product.SalePrice = float.Parse(this.textBoxSalePrice.Text);

                this.productBusiness.InsertUpdateProduct(product);

                MessageBox.Show(this, Resources.ProductSaveSuccess, Resources.Success, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.ProductSaveError, Resources.Error, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
