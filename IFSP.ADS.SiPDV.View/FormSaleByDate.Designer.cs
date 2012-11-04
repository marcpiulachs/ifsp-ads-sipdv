namespace IFSP.ADS.SiPDV.View
{
    partial class FormSaleByDate
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
            this.dateTimePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.labelDateTimeInitial = new System.Windows.Forms.Label();
            this.labelDateTimeFinal = new System.Windows.Forms.Label();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.buttonLoadReport = new System.Windows.Forms.Button();
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
            // dateTimePickerInitial
            // 
            this.dateTimePickerInitial.Location = new System.Drawing.Point(114, 12);
            this.dateTimePickerInitial.Name = "dateTimePickerInitial";
            this.dateTimePickerInitial.Size = new System.Drawing.Size(305, 18);
            this.dateTimePickerInitial.TabIndex = 1;
            // 
            // labelDateTimeInitial
            // 
            this.labelDateTimeInitial.AutoSize = true;
            this.labelDateTimeInitial.Location = new System.Drawing.Point(12, 18);
            this.labelDateTimeInitial.Name = "labelDateTimeInitial";
            this.labelDateTimeInitial.Size = new System.Drawing.Size(96, 11);
            this.labelDateTimeInitial.TabIndex = 2;
            this.labelDateTimeInitial.Text = "Data inicial:";
            // 
            // labelDateTimeFinal
            // 
            this.labelDateTimeFinal.AutoSize = true;
            this.labelDateTimeFinal.Location = new System.Drawing.Point(12, 42);
            this.labelDateTimeFinal.Name = "labelDateTimeFinal";
            this.labelDateTimeFinal.Size = new System.Drawing.Size(82, 11);
            this.labelDateTimeFinal.TabIndex = 3;
            this.labelDateTimeFinal.Text = "Data final:";
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Location = new System.Drawing.Point(114, 36);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.Size = new System.Drawing.Size(305, 18);
            this.dateTimePickerFinal.TabIndex = 4;
            // 
            // buttonLoadReport
            // 
            this.buttonLoadReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadReport.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Enter;
            this.buttonLoadReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLoadReport.Location = new System.Drawing.Point(652, 12);
            this.buttonLoadReport.Name = "buttonLoadReport";
            this.buttonLoadReport.Size = new System.Drawing.Size(120, 42);
            this.buttonLoadReport.TabIndex = 5;
            this.buttonLoadReport.Text = "Carregar Relatório";
            this.buttonLoadReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLoadReport.UseVisualStyleBackColor = true;
            this.buttonLoadReport.Click += new System.EventHandler(this.buttonLoadReport_Click);
            // 
            // FormSaleByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 592);
            this.Controls.Add(this.buttonLoadReport);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.labelDateTimeFinal);
            this.Controls.Add(this.labelDateTimeInitial);
            this.Controls.Add(this.dateTimePickerInitial);
            this.Controls.Add(this.crystalReportViewer);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 630);
            this.Name = "FormSaleByDate";
            this.Text = "SiPDV - Relatório de Vendas por Período";
            this.Load += new System.EventHandler(this.FormSaleByDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.DateTimePicker dateTimePickerInitial;
        private System.Windows.Forms.Label labelDateTimeInitial;
        private System.Windows.Forms.Label labelDateTimeFinal;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Button buttonLoadReport;
    }
}