namespace IFSP.ADS.SiPDV.View
{
    partial class FormSale
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
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.labelRs2 = new System.Windows.Forms.Label();
            this.labelRs1 = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBarCode = new System.Windows.Forms.TextBox();
            this.labelBarCode = new System.Windows.Forms.Label();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.buttonConfirmSale = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonCancelItem = new System.Windows.Forms.Button();
            this.groupBoxTotal.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.groupBoxItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTotal.Controls.Add(this.textBoxTotal);
            this.groupBoxTotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTotal.Location = new System.Drawing.Point(12, 486);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(279, 64);
            this.groupBoxTotal.TabIndex = 2;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Text = "Total";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTotal.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(6, 22);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(267, 34);
            this.textBoxTotal.TabIndex = 3;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProducts.Controls.Add(this.listBoxProducts);
            this.groupBoxProducts.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProducts.Location = new System.Drawing.Point(297, 104);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(475, 446);
            this.groupBoxProducts.TabIndex = 1;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Listagem de Produtos";
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxProducts.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Items.AddRange(new object[] {
            "1234567890123 12345678901234567890 123 1234,56 1234,56"});
            this.listBoxProducts.Location = new System.Drawing.Point(6, 22);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(463, 420);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxProducts_DrawItem);
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxProduct.Controls.Add(this.labelRs2);
            this.groupBoxProduct.Controls.Add(this.labelRs1);
            this.groupBoxProduct.Controls.Add(this.labelSeparator);
            this.groupBoxProduct.Controls.Add(this.textBoxSubtotal);
            this.groupBoxProduct.Controls.Add(this.labelSubtotal);
            this.groupBoxProduct.Controls.Add(this.textBoxPrice);
            this.groupBoxProduct.Controls.Add(this.labelPrice);
            this.groupBoxProduct.Controls.Add(this.textBoxQuantity);
            this.groupBoxProduct.Controls.Add(this.labelQuantity);
            this.groupBoxProduct.Controls.Add(this.labelName);
            this.groupBoxProduct.Controls.Add(this.textBoxName);
            this.groupBoxProduct.Controls.Add(this.textBoxBarCode);
            this.groupBoxProduct.Controls.Add(this.labelBarCode);
            this.groupBoxProduct.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduct.Location = new System.Drawing.Point(12, 104);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(279, 306);
            this.groupBoxProduct.TabIndex = 0;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Produto";
            // 
            // labelRs2
            // 
            this.labelRs2.AutoSize = true;
            this.labelRs2.Location = new System.Drawing.Point(6, 247);
            this.labelRs2.Name = "labelRs2";
            this.labelRs2.Size = new System.Drawing.Size(30, 16);
            this.labelRs2.TabIndex = 12;
            this.labelRs2.Text = "R$";
            // 
            // labelRs1
            // 
            this.labelRs1.AutoSize = true;
            this.labelRs1.Location = new System.Drawing.Point(6, 202);
            this.labelRs1.Name = "labelRs1";
            this.labelRs1.Size = new System.Drawing.Size(30, 16);
            this.labelRs1.TabIndex = 11;
            this.labelRs1.Text = "R$";
            // 
            // labelSeparator
            // 
            this.labelSeparator.Location = new System.Drawing.Point(6, 112);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(267, 23);
            this.labelSeparator.TabIndex = 4;
            this.labelSeparator.Text = "______________________________";
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubtotal.Location = new System.Drawing.Point(42, 244);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(75, 23);
            this.textBoxSubtotal.TabIndex = 10;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(6, 225);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(107, 16);
            this.labelSubtotal.TabIndex = 9;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(42, 199);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxPrice.TabIndex = 8;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(6, 180);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(173, 16);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Valor Unitário:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(6, 41);
            this.textBoxQuantity.MaxLength = 2;
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(25, 23);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "01";
            this.textBoxQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuantity_KeyDown);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(6, 22);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(217, 16);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "Quantidade (KG/UN):";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 16);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Nome:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(6, 154);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(205, 23);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxBarCode
            // 
            this.textBoxBarCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarCode.Location = new System.Drawing.Point(6, 86);
            this.textBoxBarCode.MaxLength = 13;
            this.textBoxBarCode.Name = "textBoxBarCode";
            this.textBoxBarCode.Size = new System.Drawing.Size(135, 23);
            this.textBoxBarCode.TabIndex = 3;
            this.textBoxBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBarCode_KeyDown);
            // 
            // labelBarCode
            // 
            this.labelBarCode.AutoSize = true;
            this.labelBarCode.Location = new System.Drawing.Point(6, 67);
            this.labelBarCode.Name = "labelBarCode";
            this.labelBarCode.Size = new System.Drawing.Size(195, 16);
            this.labelBarCode.TabIndex = 2;
            this.labelBarCode.Text = "Código de Barras:";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxItems.Controls.Add(this.textBoxItems);
            this.groupBoxItems.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItems.Location = new System.Drawing.Point(12, 416);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(279, 64);
            this.groupBoxItems.TabIndex = 3;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Itens";
            // 
            // textBoxItems
            // 
            this.textBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItems.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxItems.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItems.Location = new System.Drawing.Point(6, 22);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.ReadOnly = true;
            this.textBoxItems.Size = new System.Drawing.Size(267, 34);
            this.textBoxItems.TabIndex = 3;
            this.textBoxItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConfirmSale
            // 
            this.buttonConfirmSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmSale.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmSale.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Ok;
            this.buttonConfirmSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmSale.Location = new System.Drawing.Point(572, 12);
            this.buttonConfirmSale.Name = "buttonConfirmSale";
            this.buttonConfirmSale.Size = new System.Drawing.Size(200, 40);
            this.buttonConfirmSale.TabIndex = 12;
            this.buttonConfirmSale.Text = "Fechar Venda";
            this.buttonConfirmSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmSale.UseVisualStyleBackColor = true;
            this.buttonConfirmSale.Click += new System.EventHandler(this.buttonConfirmSale_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(572, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar Venda";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddProduct.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.New;
            this.buttonAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddProduct.Location = new System.Drawing.Point(366, 12);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(200, 40);
            this.buttonAddProduct.TabIndex = 10;
            this.buttonAddProduct.Text = "Adicionar Item";
            this.buttonAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonCancelItem
            // 
            this.buttonCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelItem.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Cancel;
            this.buttonCancelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelItem.Location = new System.Drawing.Point(366, 58);
            this.buttonCancelItem.Name = "buttonCancelItem";
            this.buttonCancelItem.Size = new System.Drawing.Size(200, 40);
            this.buttonCancelItem.TabIndex = 9;
            this.buttonCancelItem.Text = "Cancelar Item";
            this.buttonCancelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelItem.UseVisualStyleBackColor = true;
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.buttonConfirmSale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonCancelItem);
            this.Controls.Add(this.groupBoxItems);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.groupBoxTotal);
            this.Controls.Add(this.groupBoxProducts);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormSale";
            this.Text = "SiPDV - Venda";
            this.Load += new System.EventHandler(this.FormSale_Load);
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.groupBoxProducts.ResumeLayout(false);
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxItems.ResumeLayout(false);
            this.groupBoxItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBarCode;
        private System.Windows.Forms.Label labelBarCode;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label labelRs2;
        private System.Windows.Forms.Label labelRs1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.Button buttonConfirmSale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonCancelItem;
    }
}