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
    public partial class FormAddProduct : Form
    {
        #region -Private Attributes-

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormAddProduct()
        {
            InitializeComponent();

            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Event Handling-

        /// <summary>
        /// Delegate para declaração do evento para adicionar produto.
        /// </summary>
        /// <param name="product">Produto que será adicionado</param>
        public delegate void AddProductEventHandler(Product product);

        /// <summary>
        /// Evento para adicionar um produto.
        /// </summary>
        public event AddProductEventHandler AddProduct;

        /// <summary>
        /// Lança evento para adicionar produto.
        /// </summary>
        /// <param name="product">Produto que será adicionado</param>
        public void ThrowAddProduct(Product product)
        {
            AddProductEventHandler handler = AddProduct;

            if (handler != null)
            {
                AddProduct(product);
            }
        }

        #endregion

        #region -Events-

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            LoadAllProductsSale();
        }

        private void textBoxSearchBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchBarCode.Text))
                {
                    LoadProductSaleByBarCode(this.textBoxSearchBarCode.Text);
                }
            }
        }

        private void textBoxSearchBarCode_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchBarCode.Text.Length == 0)
            {
                LoadAllProductsSale();
            }
        }

        private void textBoxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
                {
                    LoadProductsSaleByName(this.textBoxSearchName.Text);
                }
            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchName.Text.Length == 0)
            {
                LoadAllProductsSale();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxSearchBarCode.Text))
            {
                LoadProductSaleByBarCode(this.textBoxSearchBarCode.Text);
            }
            else if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
            {
                LoadProductsSaleByName(this.textBoxSearchName.Text);
            }
            else
            {
                LoadAllProductsSale();
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // Verifica se algum produto foi selecionado.
            if (this.dataGridViewProducts.SelectedRows.Count > 0)
            {
                Product product = new Product();
                product.Id = int.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());
                product.BarCode = long.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString());
                product.Name = this.dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString();
                product.Description = this.dataGridViewProducts.SelectedRows[0].Cells[3].Value.ToString();
                product.MeasurementUnit = this.dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
                product.CostPrice = float.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[5].Value.ToString());
                product.SalePrice = float.Parse(this.dataGridViewProducts.SelectedRows[0].Cells[6].Value.ToString());

                // Lança evento para ser capturado no FormSale ou no FormTables.
                ThrowAddProduct(product);

                this.Close();
            }
            else
            {
                // MessageBox.
            }
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Carrega todos os produtos para venda.
        /// </summary>
        private void LoadAllProductsSale()
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetAllProductsSale();
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
        /// Carrega produto para venda pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        private void LoadProductSaleByBarCode(string barCode)
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetProductSaleByBarCode(long.Parse(barCode));
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
        /// Carrega produtos para venda pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        private void LoadProductsSaleByName(string name)
        {
            try
            {
                this.dataGridViewProducts.DataSource = this.productBusiness.GetProductsSaleByName(name);
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
