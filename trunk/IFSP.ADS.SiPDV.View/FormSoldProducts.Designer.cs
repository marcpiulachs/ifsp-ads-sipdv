namespace IFSP.ADS.SiPDV.View
{
    partial class FormSoldProducts
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonLoadReport = new System.Windows.Forms.Button();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.labelDateTimeFinal = new System.Windows.Forms.Label();
            this.labelDateTimeInitial = new System.Windows.Forms.Label();
            this.dateTimePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.radioButtonBestSellers = new System.Windows.Forms.RadioButton();
            this.radioButtonWorstSellers = new System.Windows.Forms.RadioButton();
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
            this.crystalReportViewer.Location = new System.Drawing.Point(12, 85);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(760, 495);
            this.crystalReportViewer.TabIndex = 0;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // buttonLoadReport
            // 
            this.buttonLoadReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadReport.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Enter;
            this.buttonLoadReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadReport.Location = new System.Drawing.Point(652, 37);
            this.buttonLoadReport.Name = "buttonLoadReport";
            this.buttonLoadReport.Size = new System.Drawing.Size(120, 42);
            this.buttonLoadReport.TabIndex = 10;
            this.buttonLoadReport.Text = "Carregar Relatório";
            this.buttonLoadReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoadReport.UseVisualStyleBackColor = true;
            this.buttonLoadReport.Click += new System.EventHandler(this.buttonLoadReport_Click);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(112, 61);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(305, 18);
            this.dateTimePickerFinal.TabIndex = 9;
            // 
            // labelDateTimeFinal
            // 
            this.labelDateTimeFinal.AutoSize = true;
            this.labelDateTimeFinal.Location = new System.Drawing.Point(10, 67);
            this.labelDateTimeFinal.Name = "labelDateTimeFinal";
            this.labelDateTimeFinal.Size = new System.Drawing.Size(82, 11);
            this.labelDateTimeFinal.TabIndex = 8;
            this.labelDateTimeFinal.Text = "Data final:";
            // 
            // labelDateTimeInitial
            // 
            this.labelDateTimeInitial.AutoSize = true;
            this.labelDateTimeInitial.Location = new System.Drawing.Point(10, 43);
            this.labelDateTimeInitial.Name = "labelDateTimeInitial";
            this.labelDateTimeInitial.Size = new System.Drawing.Size(96, 11);
            this.labelDateTimeInitial.TabIndex = 7;
            this.labelDateTimeInitial.Text = "Data inicial:";
            // 
            // dateTimePickerInitial
            // 
            this.dateTimePickerInitial.Location = new System.Drawing.Point(112, 37);
            this.dateTimePickerInitial.Name = "dateTimePickerInitial";
            this.dateTimePickerInitial.Size = new System.Drawing.Size(305, 18);
            this.dateTimePickerInitial.TabIndex = 6;
            // 
            // radioButtonBestSellers
            // 
            this.radioButtonBestSellers.AutoSize = true;
            this.radioButtonBestSellers.Checked = true;
            this.radioButtonBestSellers.Location = new System.Drawing.Point(12, 12);
            this.radioButtonBestSellers.Name = "radioButtonBestSellers";
            this.radioButtonBestSellers.Size = new System.Drawing.Size(114, 15);
            this.radioButtonBestSellers.TabIndex = 11;
            this.radioButtonBestSellers.TabStop = true;
            this.radioButtonBestSellers.Text = "Mais vendidos";
            this.radioButtonBestSellers.UseVisualStyleBackColor = true;
            // 
            // radioButtonWorstSellers
            // 
            this.radioButtonWorstSellers.AutoSize = true;
            this.radioButtonWorstSellers.Location = new System.Drawing.Point(132, 12);
            this.radioButtonWorstSellers.Name = "radioButtonWorstSellers";
            this.radioButtonWorstSellers.Size = new System.Drawing.Size(121, 15);
            this.radioButtonWorstSellers.TabIndex = 12;
            this.radioButtonWorstSellers.Text = "Menos vendidos";
            this.radioButtonWorstSellers.UseVisualStyleBackColor = true;
            // 
            // FormSoldProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.radioButtonWorstSellers);
            this.Controls.Add(this.radioButtonBestSellers);
            this.Controls.Add(this.buttonLoadReport);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.labelDateTimeFinal);
            this.Controls.Add(this.labelDateTimeInitial);
            this.Controls.Add(this.dateTimePickerInitial);
            this.Controls.Add(this.crystalReportViewer);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "FormSoldProducts";
            this.Text = "SiPDV - Relatório de Produtos Vendidos";
            this.Load += new System.EventHandler(this.FormSoldProducts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Button buttonLoadReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label labelDateTimeFinal;
        private System.Windows.Forms.Label labelDateTimeInitial;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitial;
        private System.Windows.Forms.RadioButton radioButtonBestSellers;
        private System.Windows.Forms.RadioButton radioButtonWorstSellers;
    }
}