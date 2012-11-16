namespace IFSP.ADS.SiPDV.View
{
    partial class FormMissingProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMissingProducts));
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonLoadReport = new System.Windows.Forms.Button();
            this.labelMinStockQuantity = new System.Windows.Forms.Label();
            this.textBoxMinStockQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Location = new System.Drawing.Point(12, 60);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(760, 520);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonLoadReport
            // 
            this.buttonLoadReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadReport.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Enter;
            this.buttonLoadReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadReport.Location = new System.Drawing.Point(652, 12);
            this.buttonLoadReport.Name = "buttonLoadReport";
            this.buttonLoadReport.Size = new System.Drawing.Size(120, 42);
            this.buttonLoadReport.TabIndex = 6;
            this.buttonLoadReport.Text = "Carregar Relatório";
            this.buttonLoadReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoadReport.UseVisualStyleBackColor = true;
            this.buttonLoadReport.Click += new System.EventHandler(this.buttonLoadReport_Click);
            // 
            // labelMinStockQuantity
            // 
            this.labelMinStockQuantity.AutoSize = true;
            this.labelMinStockQuantity.Location = new System.Drawing.Point(12, 15);
            this.labelMinStockQuantity.Name = "labelMinStockQuantity";
            this.labelMinStockQuantity.Size = new System.Drawing.Size(348, 11);
            this.labelMinStockQuantity.TabIndex = 7;
            this.labelMinStockQuantity.Text = "Quantidade mínima de produtos no estoque (KG/UN):";
            // 
            // textBoxMinStockQuantity
            // 
            this.textBoxMinStockQuantity.Location = new System.Drawing.Point(366, 12);
            this.textBoxMinStockQuantity.Name = "textBoxMinStockQuantity";
            this.textBoxMinStockQuantity.Size = new System.Drawing.Size(100, 18);
            this.textBoxMinStockQuantity.TabIndex = 8;
            this.textBoxMinStockQuantity.Text = "20,0";
            // 
            // FormMissingProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.textBoxMinStockQuantity);
            this.Controls.Add(this.labelMinStockQuantity);
            this.Controls.Add(this.buttonLoadReport);
            this.Controls.Add(this.crystalReportViewer);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "FormMissingProducts";
            this.Text = "SiPDV - Relatório de Produtos em Falta no Estoque";
            this.Load += new System.EventHandler(this.FormMissingProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Button buttonLoadReport;
        private System.Windows.Forms.Label labelMinStockQuantity;
        private System.Windows.Forms.TextBox textBoxMinStockQuantity;
    }
}