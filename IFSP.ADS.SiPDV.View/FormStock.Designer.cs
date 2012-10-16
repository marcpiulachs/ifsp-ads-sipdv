namespace IFSP.ADS.SiPDV.View
{
    partial class FormStock
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
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescriprion = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.radioButtonProductIn = new System.Windows.Forms.RadioButton();
            this.radioButtonProductOut = new System.Windows.Forms.RadioButton();
            this.groupBoxSearchProducts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchProducts = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchBarCode = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchBarCode = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBoxProduct.SuspendLayout();
            this.tableLayoutPanelProduct.SuspendLayout();
            this.groupBoxSearchProducts.SuspendLayout();
            this.tableLayoutPanelSearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProduct.Controls.Add(this.buttonSave);
            this.groupBoxProduct.Controls.Add(this.tableLayoutPanelProduct);
            this.groupBoxProduct.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduct.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(760, 220);
            this.groupBoxProduct.TabIndex = 0;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Produto do Estoque";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Save;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(613, 21);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 40);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanelProduct
            // 
            this.tableLayoutPanelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelProduct.ColumnCount = 2;
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxDescription, 1, 2);
            this.tableLayoutPanelProduct.Controls.Add(this.labelBarCode, 0, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.labelDescriprion, 0, 2);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxBarCode, 1, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.labelQuantity, 0, 5);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxQuantity, 1, 5);
            this.tableLayoutPanelProduct.Controls.Add(this.radioButtonProductIn, 1, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.radioButtonProductOut, 1, 4);
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(7, 21);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 6;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(600, 180);
            this.tableLayoutPanelProduct.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDescription.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(213, 61);
            this.textBoxDescription.MaxLength = 35;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.Size = new System.Drawing.Size(355, 23);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelBarCode
            // 
            this.labelBarCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBarCode.Location = new System.Drawing.Point(29, 6);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(178, 16);
            this.labelBarCode.TabIndex = 0;
            this.labelBarCode.Text = "Código de Barras:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(149, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 16);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nome:";
            // 
            // labelDescriprion
            // 
            this.labelDescriprion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDescriprion.AutoSize = true;
            this.labelDescriprion.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriprion.Location = new System.Drawing.Point(99, 64);
            this.labelDescriprion.Name = "labelDescriprion";
            this.labelDescriprion.Size = new System.Drawing.Size(108, 16);
            this.labelDescriprion.TabIndex = 4;
            this.labelDescriprion.Text = "Descrição:";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBarCode.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarCode.Location = new System.Drawing.Point(213, 3);
            this.textBoxBarCode.MaxLength = 13;
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.ReadOnly = true;
            this.textBoxBarCode.Size = new System.Drawing.Size(135, 23);
            this.textBoxBarCode.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(213, 32);
            this.textBoxName.MaxLength = 20;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(205, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(89, 154);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(118, 16);
            this.labelQuantity.TabIndex = 8;
            this.labelQuantity.Text = "Quantidade:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxQuantity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(213, 151);
            this.textBoxQuantity.MaxLength = 13;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(135, 23);
            this.textBoxQuantity.TabIndex = 9;
            this.textBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantity_KeyPress);
            // 
            // radioButtonProductIn
            // 
            this.radioButtonProductIn.AutoSize = true;
            this.radioButtonProductIn.Checked = true;
            this.radioButtonProductIn.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProductIn.Location = new System.Drawing.Point(213, 90);
            this.radioButtonProductIn.Name = "radioButtonProductIn";
            this.radioButtonProductIn.Size = new System.Drawing.Size(206, 20);
            this.radioButtonProductIn.TabIndex = 6;
            this.radioButtonProductIn.TabStop = true;
            this.radioButtonProductIn.Text = "Entrada no Estoque";
            this.radioButtonProductIn.UseVisualStyleBackColor = true;
            // 
            // radioButtonProductOut
            // 
            this.radioButtonProductOut.AutoSize = true;
            this.radioButtonProductOut.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProductOut.Location = new System.Drawing.Point(213, 119);
            this.radioButtonProductOut.Name = "radioButtonProductOut";
            this.radioButtonProductOut.Size = new System.Drawing.Size(186, 20);
            this.radioButtonProductOut.TabIndex = 7;
            this.radioButtonProductOut.TabStop = true;
            this.radioButtonProductOut.Text = "Saída do Estoque";
            this.radioButtonProductOut.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchProducts
            // 
            this.groupBoxSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchProducts.Controls.Add(this.tableLayoutPanelSearchProducts);
            this.groupBoxSearchProducts.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchProducts.Location = new System.Drawing.Point(12, 238);
            this.groupBoxSearchProducts.Name = "groupBoxSearchProducts";
            this.groupBoxSearchProducts.Size = new System.Drawing.Size(760, 70);
            this.groupBoxSearchProducts.TabIndex = 1;
            this.groupBoxSearchProducts.TabStop = false;
            this.groupBoxSearchProducts.Text = "Buscar Produtos";
            // 
            // tableLayoutPanelSearchProducts
            // 
            this.tableLayoutPanelSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSearchProducts.ColumnCount = 5;
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelSearchProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelSearchProducts.Controls.Add(this.labelSearchBarCode, 0, 0);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.labelSearchName, 2, 0);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.textBoxSearchBarCode, 1, 0);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.textBoxSearchName, 3, 0);
            this.tableLayoutPanelSearchProducts.Controls.Add(this.buttonSearch, 4, 0);
            this.tableLayoutPanelSearchProducts.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanelSearchProducts.Name = "tableLayoutPanelSearchProducts";
            this.tableLayoutPanelSearchProducts.RowCount = 1;
            this.tableLayoutPanelSearchProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchProducts.Size = new System.Drawing.Size(746, 30);
            this.tableLayoutPanelSearchProducts.TabIndex = 0;
            // 
            // labelSearchBarCode
            // 
            this.labelSearchBarCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchBarCode.AutoSize = true;
            this.labelSearchBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchBarCode.Location = new System.Drawing.Point(5, 7);
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
            this.labelSearchName.Location = new System.Drawing.Point(348, 7);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(58, 16);
            this.labelSearchName.TabIndex = 2;
            this.labelSearchName.Text = "Nome:";
            // 
            // textBoxSearchBarCode
            // 
            this.textBoxSearchBarCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearchBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBarCode.Location = new System.Drawing.Point(189, 3);
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
            this.textBoxSearchName.Location = new System.Drawing.Point(412, 3);
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
            this.buttonSearch.Location = new System.Drawing.Point(635, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(108, 24);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 314);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(760, 236);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.groupBoxSearchProducts);
            this.Controls.Add(this.dataGridViewProducts);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormStock";
            this.Text = "SiPDV - Estoque";
            this.Load += new System.EventHandler(this.FormStock_Load);
            this.groupBoxProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.PerformLayout();
            this.groupBoxSearchProducts.ResumeLayout(false);
            this.tableLayoutPanelSearchProducts.ResumeLayout(false);
            this.tableLayoutPanelSearchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescriprion;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxSearchProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchProducts;
        private System.Windows.Forms.Label labelSearchBarCode;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchBarCode;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.RadioButton radioButtonProductIn;
        private System.Windows.Forms.RadioButton radioButtonProductOut;
    }
}