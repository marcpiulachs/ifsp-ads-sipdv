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
    public partial class FormTables : Form
    {
        #region -Constants-

        /// <summary>
        /// Cabeçalho da lista de produtos.
        /// </summary>
        private const string LIST_BOX_HEADER = "CÓDIGO        NOME                 QTD   PREÇO  SUBTOT";

        #endregion

        #region -Private Attributes-

        private FormAddProduct frmAddProduct;
        private FormConfirmSale frmConfirmSale;

        private Product currentProduct;
        private Table currentTable;
        private List<Table> lstTables;

        private ProductBusiness productBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormTables()
        {
            InitializeComponent();
            InitializeTables();

            this.frmAddProduct = new FormAddProduct();
            this.frmAddProduct.AddProduct += new FormAddProduct.AddProductEventHandler(frmAddProduct_AddProduct);
            
            this.productBusiness = new ProductBusiness();
        }

        #endregion

        #region -Events-

        private void FormTables_Load(object sender, EventArgs e)
        {
            InitializeListBox();
            LoadTable(0);
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
                AddProduct(this.currentTable.Number - 1);
                CountItemsAndCalculateSubtotal(this.currentTable.Number - 1);

                this.textBoxBarCode.Text = string.Empty;
                this.textBoxBarCode.Focus();
            }
        }

        private void textBoxBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true;
            }
        }

        private void buttonTable01_Click(object sender, EventArgs e)
        {
            LoadTable(0);
        }

        private void buttonTable02_Click(object sender, EventArgs e)
        {
            LoadTable(1);
        }

        private void buttonTable03_Click(object sender, EventArgs e)
        {
            LoadTable(2);
        }

        private void buttonTable04_Click(object sender, EventArgs e)
        {
            LoadTable(3);
        }

        private void buttonTable05_Click(object sender, EventArgs e)
        {
            LoadTable(4);
        }

        private void buttonTable06_Click(object sender, EventArgs e)
        {
            LoadTable(5);
        }

        private void buttonTable07_Click(object sender, EventArgs e)
        {
            LoadTable(6);
        }

        private void buttonTable08_Click(object sender, EventArgs e)
        {
            LoadTable(7);
        }

        private void buttonTable09_Click(object sender, EventArgs e)
        {
            LoadTable(8);
        }

        private void buttonTable10_Click(object sender, EventArgs e)
        {
            LoadTable(9);
        }

        private void buttonTable11_Click(object sender, EventArgs e)
        {
            LoadTable(10);
        }

        private void buttonTable12_Click(object sender, EventArgs e)
        {
            LoadTable(11);
        }

        private void buttonTable13_Click(object sender, EventArgs e)
        {
            LoadTable(12);
        }

        private void buttonTable14_Click(object sender, EventArgs e)
        {
            LoadTable(13);
        }

        private void buttonTable15_Click(object sender, EventArgs e)
        {
            LoadTable(14);
        }

        private void buttonTable16_Click(object sender, EventArgs e)
        {
            LoadTable(15);
        }

        private void buttonTable17_Click(object sender, EventArgs e)
        {
            LoadTable(16);
        }

        private void buttonTable18_Click(object sender, EventArgs e)
        {
            LoadTable(17);
        }

        private void buttonTable19_Click(object sender, EventArgs e)
        {
            LoadTable(18);
        }

        private void buttonTable20_Click(object sender, EventArgs e)
        {
            LoadTable(19);
        }

        private void buttonTable21_Click(object sender, EventArgs e)
        {
            LoadTable(20);
        }

        private void buttonTable22_Click(object sender, EventArgs e)
        {
            LoadTable(21);
        }

        private void buttonTable23_Click(object sender, EventArgs e)
        {
            LoadTable(22);
        }

        private void buttonTable24_Click(object sender, EventArgs e)
        {
            LoadTable(23);
        }

        private void buttonTable25_Click(object sender, EventArgs e)
        {
            LoadTable(24);
        }

        private void listBoxProducts_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Desenha o background do ListBox para cada ListBoxItem.
            e.DrawBackground();

            // Preenche o ListBoxItem com cinza caso for par, e com branco caso for ímpar.
            if ((e.Index > 0) && ((e.State & DrawItemState.Selected) == DrawItemState.Selected))
            {
                e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(e.Index % 2 == 0 ? Brushes.LightGray : Brushes.White, e.Bounds);
            }

            // Desenha o escrito do ListBoxItem.
            e.Graphics.DrawString(listBoxProducts.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds);

            // Se o ListBox tem foco, desenha o foco no ListBoxItem selecionado.
            e.DrawFocusRectangle();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            this.frmAddProduct.ShowDialog(this);
        }

        private void buttonCancelProduct_Click(object sender, EventArgs e)
        {
            RemoveProduct(this.currentTable.Number - 1);
            CountItemsAndCalculateSubtotal(this.currentTable.Number - 1);

            this.textBoxBarCode.Text = string.Empty;
            this.textBoxBarCode.Focus();
        }

        private void buttonConfirmTable_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.lstTables[this.currentTable.Number - 1].LstProducts.Count > 0)
                {
                    this.frmConfirmSale = new FormConfirmSale(this.lstTables[this.currentTable.Number - 1].LstProducts);
                    this.frmConfirmSale.ConfirmedSale += new FormConfirmSale.ConfirmedSaleEventHandler(frmConfirmSale_ConfirmedSale);
                    frmConfirmSale.ShowDialog(this);
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

        private void buttonCancelTable_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(this, Resources.TablesCancelQuestion, Resources.Question,
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                CancelTable(this.currentTable.Number - 1);
                CountItemsAndCalculateSubtotal(this.currentTable.Number - 1);
            }
        }

        private void frmAddProduct_AddProduct(Product product)
        {
            this.textBoxBarCode.Text = product.BarCode.ToString();

            AddProduct(this.currentTable.Number - 1);
            CountItemsAndCalculateSubtotal(this.currentTable.Number - 1);

            this.textBoxBarCode.Text = string.Empty;
            this.textBoxBarCode.Focus();
        }

        private void frmConfirmSale_ConfirmedSale()
        {
            this.lstTables[this.currentTable.Number - 1].LstProducts.Clear();
            LoadTable(this.currentTable.Number - 1);
            UpdateTablesStatus();
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Limpa a lista de produtos e insere o cabeçalho.
        /// </summary>
        private void InitializeListBox()
        {
            this.listBoxProducts.Items.Clear();
            this.listBoxProducts.Items.Add(LIST_BOX_HEADER);
        }

        /// <summary>
        /// Inicializa cada mesa com número e uma lista vazia de produtos.
        /// </summary>
        private void InitializeTables()
        {
            Table table;
            this.lstTables = new List<Table>();

            for (int i = 0; i < 25; i++)
            {
                table = new Table(i + 1, new List<Product>());
                this.lstTables.Add(table);
            }
        }

        /// <summary>
        /// Carrega uma mesa para exibir os produtos e demais informações.
        /// </summary>
        /// <param name="tableIndex">Índice da mesa a ser carregada</param>
        private void LoadTable(int tableIndex)
        {
            this.currentTable = this.lstTables[tableIndex];
            this.groupBoxProducts.Text = string.Format("Listagem de Produtos (Mesa {0:00})", tableIndex + 1);

            this.listBoxProducts.Items.Clear();
            this.listBoxProducts.Items.Add(LIST_BOX_HEADER);
            this.listBoxProducts.Items.AddRange(this.lstTables[tableIndex].LstProducts.ToArray());

            CountItemsAndCalculateSubtotal(tableIndex);
        }

        /// <summary>
        /// Busca o índice de um produto na lista de produtos de determinada mesa.
        /// </summary>
        /// <param name="tableIndex">Índice da mesa</param>
        /// <param name="product">Produto a ser buscado</param>
        /// <returns>Retorna o índice do produto na lista de produtos da mesa selecionada</returns>
        private int GetProductIndex(int tableIndex, Product product)
        {
            try
            {
                for (int i = 0; i < this.lstTables[tableIndex].LstProducts.Count; i++)
                {
                    if (this.lstTables[tableIndex].LstProducts[i].Id == product.Id)
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

        /// <summary>
        /// Busca a quantidade de um produto em todas em mesas.
        /// </summary>
        /// <param name="prod">Produto a ser buscado</param>
        /// <returns>Retorna a quantidade do produto em todas as mesas</returns>
        private int GetProductQuantity(Product prod)
        {
            int count = 0;

            try
            {
                foreach (Table table in this.lstTables)
                {
                    foreach (Product product in table.LstProducts)
                    {
                        if (product.Id == prod.Id)
                        {
                            count += product.Quantity;
                        }
                    }
                }

                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Adiciona um produto na lista de produtos da mesa selecionada.
        /// </summary>
        /// <param name="tableIndex">Índice da mesa</param>
        private void AddProduct(int tableIndex)
        {
            int productIndex;

            try
            {
                this.currentProduct = this.productBusiness.GetProductSale(long.Parse(this.textBoxBarCode.Text));

                if (this.currentProduct != null)
                {
                    this.currentProduct.Quantity = int.Parse(textBoxQuantity.Text);

                    // Se a quantidade a ser vendida for maior que a quantidade em estoque, exibe um alerta.
                    if (this.currentProduct.Quantity + GetProductQuantity(this.currentProduct) <= this.currentProduct.StockQuantity)
                    {
                        // Busca o índice deste produto na lista de produtos.
                        productIndex = GetProductIndex(tableIndex, this.currentProduct);

                        // Se o índice do produto for maior que 0 ele já está na lista, caso contrário ele será adicionado.
                        if (productIndex > -1)
                        {
                            this.currentProduct.Quantity += this.lstTables[tableIndex].LstProducts[productIndex].Quantity;

                            this.lstTables[tableIndex].LstProducts[productIndex] = this.currentProduct;
                            this.listBoxProducts.Items[productIndex + 1] = this.currentProduct;
                            this.listBoxProducts.SelectedIndex = productIndex + 1;
                        }
                        else
                        {
                            this.lstTables[tableIndex].LstProducts.Add(this.currentProduct);
                            this.listBoxProducts.Items.Add(this.currentProduct);
                            this.listBoxProducts.SelectedIndex = this.listBoxProducts.Items.Count - 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, Resources.StockProductNotEnough, Resources.Warning,
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(this, Resources.ProductNotExists, Resources.Warning,
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                UpdateTablesStatus();
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
        /// Remove um produto da lista de produtos da mesa selecionada.
        /// </summary>
        /// <param name="tableIndex">Índice da mesa</param>
        private void RemoveProduct(int tableIndex)
        {
            int index;

            try
            {
                index = this.listBoxProducts.SelectedIndex;

                if (index > 0)
                {
                    this.lstTables[tableIndex].LstProducts.RemoveAt(index - 1);
                    this.listBoxProducts.Items.RemoveAt(index);
                    this.listBoxProducts.SelectedIndex = this.listBoxProducts.Items.Count - 1;
                }

                UpdateTablesStatus();
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
        /// Cancela a venda dos produtos de determinada mesa.
        /// </summary>
        /// <param name="tableIndex">Índice da mesa</param>
        private void CancelTable(int tableIndex)
        {
            this.lstTables[tableIndex].LstProducts.Clear();
            this.listBoxProducts.Items.Clear();
            this.listBoxProducts.Items.Add(LIST_BOX_HEADER);

            UpdateTablesStatus();
        }

        /// <summary>
        /// Calcula a quantidade de itens na lista de produtos e o subtotal de determinada mesa.
        /// </summary>
        /// <param name="tableIndex">Índice da mesa</param>
        private void CountItemsAndCalculateSubtotal(int tableIndex)
        {
            float subtotal = 0.0F;

            try
            {
                foreach (Product product in this.lstTables[tableIndex].LstProducts)
                {
                    subtotal += product.CalculateSubtotal();
                }

                this.textBoxItems.Text = this.lstTables[tableIndex].LstProducts.Count.ToString();
                this.textBoxTotal.Text = "R$" + subtotal.ToString("0.00");
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
        /// Atualiza as cores das mesas (Verde - livre, Vermelho - ocupada).
        /// </summary>
        private void UpdateTablesStatus()
        {
            foreach (Table table in this.lstTables)
            {
                if (table.LstProducts.Count > 0)
                {
                    ((Button)this.tableLayoutPanelTables.Controls["buttonTable" + table.Number.ToString("00")]).BackColor = Color.Firebrick;
                }
                else
                {
                    ((Button)this.tableLayoutPanelTables.Controls["buttonTable" + table.Number.ToString("00")]).BackColor = Color.OliveDrab;
                }
            }
        }

        #endregion
    }
}
