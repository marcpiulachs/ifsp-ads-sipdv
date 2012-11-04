namespace IFSP.ADS.SiPDV.View
{
    partial class FormConfirmSale
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
            this.buttonConfirmSale = new System.Windows.Forms.Button();
            this.groupBoxConfirmSale = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.groupBoxConfirmSale.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirmSale
            // 
            this.buttonConfirmSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirmSale.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmSale.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Ok;
            this.buttonConfirmSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConfirmSale.Location = new System.Drawing.Point(201, 210);
            this.buttonConfirmSale.Name = "buttonConfirmSale";
            this.buttonConfirmSale.Size = new System.Drawing.Size(170, 40);
            this.buttonConfirmSale.TabIndex = 1;
            this.buttonConfirmSale.Text = "Fechar Venda";
            this.buttonConfirmSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConfirmSale.UseVisualStyleBackColor = true;
            this.buttonConfirmSale.Click += new System.EventHandler(this.buttonConfirmSale_Click);
            // 
            // groupBoxConfirmSale
            // 
            this.groupBoxConfirmSale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxConfirmSale.Controls.Add(this.tableLayoutPanel);
            this.groupBoxConfirmSale.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConfirmSale.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfirmSale.Name = "groupBoxConfirmSale";
            this.groupBoxConfirmSale.Size = new System.Drawing.Size(360, 192);
            this.groupBoxConfirmSale.TabIndex = 0;
            this.groupBoxConfirmSale.TabStop = false;
            this.groupBoxConfirmSale.Text = "Fechar Venda";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel.Controls.Add(this.textBoxTotal, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxSubtotal, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTotal, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDiscount, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelSubtotal, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelDiscount, 0, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(348, 90);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTotal.Location = new System.Drawing.Point(124, 63);
            this.textBoxTotal.MaxLength = 7;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(200, 23);
            this.textBoxTotal.TabIndex = 5;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSubtotal.Location = new System.Drawing.Point(124, 3);
            this.textBoxSubtotal.MaxLength = 7;
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.ReadOnly = true;
            this.textBoxSubtotal.Size = new System.Drawing.Size(200, 23);
            this.textBoxSubtotal.TabIndex = 1;
            this.textBoxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(44, 67);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(74, 16);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "Total:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDiscount.Location = new System.Drawing.Point(124, 33);
            this.textBoxDiscount.MaxLength = 7;
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(200, 23);
            this.textBoxDiscount.TabIndex = 3;
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxDiscount_KeyDown);
            this.textBoxDiscount.Leave += new System.EventHandler(this.textBoxDiscount_Leave);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(11, 7);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(107, 16);
            this.labelSubtotal.TabIndex = 0;
            this.labelSubtotal.Text = "Subtotal:";
            // 
            // labelDiscount
            // 
            this.labelDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(11, 37);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(107, 16);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "Desconto:";
            // 
            // FormConfirmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.groupBoxConfirmSale);
            this.Controls.Add(this.buttonConfirmSale);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormConfirmSale";
            this.Text = "Fechar Venda";
            this.groupBoxConfirmSale.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmSale;
        private System.Windows.Forms.GroupBox groupBoxConfirmSale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelDiscount;
    }
}