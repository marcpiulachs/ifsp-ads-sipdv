namespace IFSP.ADS.SiPDV.View
{
    partial class FormAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.groupBoxSearchProducts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchProducts = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchBarCode = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchBarCode = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxSearchProducts.SuspendLayout();
            this.tableLayoutPanelSearchProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 112);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(600, 272);
            this.dataGridViewProducts.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.New;
            this.buttonAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.Location = new System.Drawing.Point(412, 390);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(200, 40);
            this.buttonAddProduct.TabIndex = 2;
            this.buttonAddProduct.Text = "Adicionar Item";
            this.buttonAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // groupBoxSearchProducts
            // 
            this.groupBoxSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchProducts.Controls.Add(this.tableLayoutPanelSearchProducts);
            this.groupBoxSearchProducts.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchProducts.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSearchProducts.Name = "groupBoxSearchProducts";
            this.groupBoxSearchProducts.Size = new System.Drawing.Size(600, 94);
            this.groupBoxSearchProducts.TabIndex = 0;
            this.groupBoxSearchProducts.TabStop = false;
            this.groupBoxSearchProducts.Text = "Buscar Produtos";
            // 
            // tableLayoutPanelSearchProducts
            // 
            this.tableLayoutPanelSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSearchProducts.ColumnCount = 3;
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSearchProducts.Controls.Add(this.buttonSearch, 2, 1);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.labelSearchBarCode, 0, 0);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.labelSearchName, 0, 1);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.textBoxSearchBarCode, 1, 0);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.textBoxSearchName, 1, 1);
            this.tableLayoutPanelSearchProducts.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanelSearchProducts.Name = "tableLayoutPanelSearchProducts";
            this.tableLayoutPanelSearchProducts.RowCount = 2;
            this.tableLayoutPanelSearchProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchProducts.Size = new System.Drawing.Size(588, 60);
            this.tableLayoutPanelSearchProducts.TabIndex = 0;
            // 
            // labelSearchBarCode
            // 
            this.labelSearchBarCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchBarCode.AutoSize = true;
            this.labelSearchBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBarCode.Location = new System.Drawing.Point(54, 7);
            this.labelSearchBarCode.Name = "labelSearchBarCode";
            this.labelSearchBarCode.Size = new System.Drawing.Size(178, 16);
            this.labelSearchBarCode.TabIndex = 0;
            this.labelSearchBarCode.Text = "Código de Barras:";
            // 
            // labelSearchName
            // 
            this.labelSearchName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchName.Location = new System.Drawing.Point(174, 37);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(58, 16);
            this.labelSearchName.TabIndex = 2;
            this.labelSearchName.Text = "Nome:";
            // 
            // textBoxSearchBarCode
            // 
            this.textBoxSearchBarCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearchBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBarCode.Location = new System.Drawing.Point(238, 3);
            this.textBoxSearchBarCode.MaxLength = 13;
            this.textBoxSearchBarCode.Name = "textBoxSearchBarCode";
            this.textBoxSearchBarCode.Size = new System.Drawing.Size(135, 23);
            this.textBoxSearchBarCode.TabIndex = 1;
            this.textBoxSearchBarCode.TextChanged += new System.EventHandler(this.textBoxSearchBarCode_TextChanged);
            this.textBoxSearchBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchBarCode_KeyDown);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearchName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(238, 33);
            this.textBoxSearchName.MaxLength = 20;
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(205, 23);
            this.textBoxSearchName.TabIndex = 3;
            this.textBoxSearchName.TextChanged += new System.EventHandler(this.textBoxSearchName_TextChanged);
            this.textBoxSearchName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchName_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Search;
            this.buttonSearch.Location = new System.Drawing.Point(473, 33);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(112, 24);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.groupBoxSearchProducts);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormAddProduct";
            this.Text = "Adicionar Item";
            this.Load += new System.EventHandler(this.FormAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxSearchProducts.ResumeLayout(false);
            this.tableLayoutPanelSearchProducts.ResumeLayout(false);
            this.tableLayoutPanelSearchProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.GroupBox groupBoxSearchProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchProducts;
        private System.Windows.Forms.Label labelSearchBarCode;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchBarCode;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
    }
}