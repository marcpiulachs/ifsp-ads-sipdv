namespace IFSP.ADS.SiPDV.View
{
    partial class FormProducts
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
            this.groupBoxSearchProducts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchProducts = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchBarCode = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchBarCode = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanelProduct = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDescriprion = new System.Windows.Forms.Label();
            this.labelMeasurementUnity = new System.Windows.Forms.Label();
            this.labelCostPrice = new System.Windows.Forms.Label();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCostPrice = new System.Windows.Forms.TextBox();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.comboBoxMeasurementUnity = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonActive = new System.Windows.Forms.RadioButton();
            this.radioButtonInactive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.groupBoxSearchProducts.SuspendLayout();
            this.tableLayoutPanelSearchProducts.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.tableLayoutPanelProduct.SuspendLayout();
            this.tableLayoutPanelStatus.SuspendLayout();
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
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 344);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(760, 236);
            this.dataGridViewProducts.TabIndex = 2;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // groupBoxSearchProducts
            // 
            this.groupBoxSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchProducts.Controls.Add(this.tableLayoutPanelSearchProducts);
            this.groupBoxSearchProducts.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchProducts.Location = new System.Drawing.Point(12, 268);
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
            // groupBoxProduct
            // 
            this.groupBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProduct.Controls.Add(this.buttonSave);
            this.groupBoxProduct.Controls.Add(this.buttonNew);
            this.groupBoxProduct.Controls.Add(this.tableLayoutPanelProduct);
            this.groupBoxProduct.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduct.Location = new System.Drawing.Point(12, 12);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(760, 250);
            this.groupBoxProduct.TabIndex = 0;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Cadastrar Produto";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Save;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(613, 67);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 40);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNew.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.New;
            this.buttonNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNew.Location = new System.Drawing.Point(613, 21);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(141, 40);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "Novo";
            this.buttonNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
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
            this.tableLayoutPanelProduct.Controls.Add(this.labelMeasurementUnity, 0, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.labelCostPrice, 0, 4);
            this.tableLayoutPanelProduct.Controls.Add(this.labelSalePrice, 0, 5);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxBarCode, 1, 0);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxCostPrice, 1, 4);
            this.tableLayoutPanelProduct.Controls.Add(this.textBoxSalePrice, 1, 5);
            this.tableLayoutPanelProduct.Controls.Add(this.comboBoxMeasurementUnity, 1, 3);
            this.tableLayoutPanelProduct.Controls.Add(this.labelStatus, 0, 6);
            this.tableLayoutPanelProduct.Controls.Add(this.tableLayoutPanelStatus, 1, 6);
            this.tableLayoutPanelProduct.Location = new System.Drawing.Point(7, 21);
            this.tableLayoutPanelProduct.Name = "tableLayoutPanelProduct";
            this.tableLayoutPanelProduct.RowCount = 7;
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelProduct.Size = new System.Drawing.Size(600, 210);
            this.tableLayoutPanelProduct.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDescription.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(213, 61);
            this.textBoxDescription.MaxLength = 35;
            this.textBoxDescription.Name = "textBoxDescription";
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
            // labelMeasurementUnity
            // 
            this.labelMeasurementUnity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMeasurementUnity.AutoSize = true;
            this.labelMeasurementUnity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeasurementUnity.Location = new System.Drawing.Point(19, 94);
            this.labelMeasurementUnity.Name = "labelMeasurementUnity";
            this.labelMeasurementUnity.Size = new System.Drawing.Size(188, 16);
            this.labelMeasurementUnity.TabIndex = 6;
            this.labelMeasurementUnity.Text = "Unidade de Medida:";
            // 
            // labelCostPrice
            // 
            this.labelCostPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCostPrice.AutoSize = true;
            this.labelCostPrice.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostPrice.Location = new System.Drawing.Point(49, 123);
            this.labelCostPrice.Name = "labelCostPrice";
            this.labelCostPrice.Size = new System.Drawing.Size(158, 16);
            this.labelCostPrice.TabIndex = 8;
            this.labelCostPrice.Text = "Preço de Custo:";
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSalePrice.AutoSize = true;
            this.labelSalePrice.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalePrice.Location = new System.Drawing.Point(49, 152);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(158, 16);
            this.labelSalePrice.TabIndex = 10;
            this.labelSalePrice.Text = "Preço de Venda:";
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarCode.Location = new System.Drawing.Point(213, 3);
            this.textBoxBarCode.MaxLength = 13;
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(135, 23);
            this.textBoxBarCode.TabIndex = 1;
            this.textBoxBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarCode_KeyDown);
            this.textBoxBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBarCode_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(213, 32);
            this.textBoxName.MaxLength = 20;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxCostPrice
            // 
            this.textBoxCostPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCostPrice.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostPrice.Location = new System.Drawing.Point(213, 120);
            this.textBoxCostPrice.MaxLength = 7;
            this.textBoxCostPrice.Name = "textBoxCostPrice";
            this.textBoxCostPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxCostPrice.TabIndex = 9;
            this.textBoxCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCostPrice_KeyPress);
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSalePrice.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSalePrice.Location = new System.Drawing.Point(213, 149);
            this.textBoxSalePrice.MaxLength = 7;
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxSalePrice.TabIndex = 11;
            this.textBoxSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalePrice_KeyPress);
            // 
            // comboBoxMeasurementUnity
            // 
            this.comboBoxMeasurementUnity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxMeasurementUnity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeasurementUnity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMeasurementUnity.FormattingEnabled = true;
            this.comboBoxMeasurementUnity.Items.AddRange(new object[] {
            "KG",
            "UN"});
            this.comboBoxMeasurementUnity.Location = new System.Drawing.Point(213, 90);
            this.comboBoxMeasurementUnity.Name = "comboBoxMeasurementUnity";
            this.comboBoxMeasurementUnity.Size = new System.Drawing.Size(75, 24);
            this.comboBoxMeasurementUnity.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(129, 184);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(78, 16);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Status:";
            // 
            // tableLayoutPanelStatus
            // 
            this.tableLayoutPanelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanelStatus.ColumnCount = 2;
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanelStatus.Controls.Add(this.radioButtonActive, 0, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.radioButtonInactive, 1, 0);
            this.tableLayoutPanelStatus.Location = new System.Drawing.Point(213, 178);
            this.tableLayoutPanelStatus.Name = "tableLayoutPanelStatus";
            this.tableLayoutPanelStatus.RowCount = 1;
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStatus.Size = new System.Drawing.Size(192, 29);
            this.tableLayoutPanelStatus.TabIndex = 13;
            // 
            // radioButtonActive
            // 
            this.radioButtonActive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonActive.AutoSize = true;
            this.radioButtonActive.Checked = true;
            this.radioButtonActive.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonActive.Location = new System.Drawing.Point(3, 4);
            this.radioButtonActive.Name = "radioButtonActive";
            this.radioButtonActive.Size = new System.Drawing.Size(76, 20);
            this.radioButtonActive.TabIndex = 0;
            this.radioButtonActive.TabStop = true;
            this.radioButtonActive.Text = "Ativo";
            this.radioButtonActive.UseVisualStyleBackColor = true;
            // 
            // radioButtonInactive
            // 
            this.radioButtonInactive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButtonInactive.AutoSize = true;
            this.radioButtonInactive.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInactive.Location = new System.Drawing.Point(88, 4);
            this.radioButtonInactive.Name = "radioButtonInactive";
            this.radioButtonInactive.Size = new System.Drawing.Size(96, 20);
            this.radioButtonInactive.TabIndex = 1;
            this.radioButtonInactive.Text = "Inativo";
            this.radioButtonInactive.UseVisualStyleBackColor = true;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.groupBoxSearchProducts);
            this.Controls.Add(this.dataGridViewProducts);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "FormProducts";
            this.Text = "SiPDV - Produtos";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.groupBoxSearchProducts.ResumeLayout(false);
            this.tableLayoutPanelSearchProducts.ResumeLayout(false);
            this.tableLayoutPanelSearchProducts.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.ResumeLayout(false);
            this.tableLayoutPanelProduct.PerformLayout();
            this.tableLayoutPanelStatus.ResumeLayout(false);
            this.tableLayoutPanelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox groupBoxSearchProducts;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchProducts;
        private System.Windows.Forms.Label labelSearchBarCode;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchBarCode;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProduct;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDescriprion;
        private System.Windows.Forms.Label labelMeasurementUnity;
        private System.Windows.Forms.Label labelCostPrice;
        private System.Windows.Forms.Label labelSalePrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCostPrice;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.ComboBox comboBoxMeasurementUnity;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatus;
        private System.Windows.Forms.RadioButton radioButtonActive;
        private System.Windows.Forms.RadioButton radioButtonInactive;
    }
}