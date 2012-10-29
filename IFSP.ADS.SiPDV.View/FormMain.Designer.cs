namespace IFSP.ADS.SiPDV.View
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelOperator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelOperatorValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHour = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHourValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVersionValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem,
            this.tablesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.operatorsToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.configurationToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 48);
            this.menuStrip.TabIndex = 1;
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleToolStripMenuItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Sale;
            this.saleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(96, 44);
            this.saleToolStripMenuItem.Text = "Venda";
            this.saleToolStripMenuItem.Click += new System.EventHandler(this.saleToolStripMenuItem_Click);
            // 
            // tablesToolStripMenuItem
            // 
            this.tablesToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesToolStripMenuItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Table;
            this.tablesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            this.tablesToolStripMenuItem.Size = new System.Drawing.Size(96, 44);
            this.tablesToolStripMenuItem.Text = "Mesas";
            this.tablesToolStripMenuItem.Click += new System.EventHandler(this.tablesToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productsToolStripMenuItem.Image")));
            this.productsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(123, 44);
            this.productsToolStripMenuItem.Text = "Produtos";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // operatorsToolStripMenuItem
            // 
            this.operatorsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorsToolStripMenuItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Operator;
            this.operatorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.operatorsToolStripMenuItem.Name = "operatorsToolStripMenuItem";
            this.operatorsToolStripMenuItem.Size = new System.Drawing.Size(141, 44);
            this.operatorsToolStripMenuItem.Text = "Operadores";
            this.operatorsToolStripMenuItem.Click += new System.EventHandler(this.operatorsToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockToolStripMenuItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Stock;
            this.stockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(114, 44);
            this.stockToolStripMenuItem.Text = "Estoque";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Report;
            this.reportsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(141, 44);
            this.reportsToolStripMenuItem.Text = "Relatórios";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurationToolStripMenuItem.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Configuration;
            this.configurationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(168, 44);
            this.configurationToolStripMenuItem.Text = "Configurações";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelOperator,
            this.toolStripStatusLabelOperatorValue,
            this.toolStripStatusLabelDate,
            this.toolStripStatusLabelDateValue,
            this.toolStripStatusLabelHour,
            this.toolStripStatusLabelHourValue,
            this.toolStripStatusLabelSpace,
            this.toolStripStatusLabelVersion,
            this.toolStripStatusLabelVersionValue});
            this.statusStrip.Location = new System.Drawing.Point(0, 638);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 24);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabelOperator
            // 
            this.toolStripStatusLabelOperator.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelOperator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelOperator.Name = "toolStripStatusLabelOperator";
            this.toolStripStatusLabelOperator.Size = new System.Drawing.Size(63, 19);
            this.toolStripStatusLabelOperator.Text = "Operador:";
            // 
            // toolStripStatusLabelOperatorValue
            // 
            this.toolStripStatusLabelOperatorValue.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelOperatorValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelOperatorValue.Name = "toolStripStatusLabelOperatorValue";
            this.toolStripStatusLabelOperatorValue.Size = new System.Drawing.Size(78, 19);
            this.toolStripStatusLabelOperatorValue.Text = "João da Silva";
            // 
            // toolStripStatusLabelDate
            // 
            this.toolStripStatusLabelDate.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelDate.Name = "toolStripStatusLabelDate";
            this.toolStripStatusLabelDate.Size = new System.Drawing.Size(36, 19);
            this.toolStripStatusLabelDate.Text = "Data:";
            // 
            // toolStripStatusLabelDateValue
            // 
            this.toolStripStatusLabelDateValue.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelDateValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelDateValue.Name = "toolStripStatusLabelDateValue";
            this.toolStripStatusLabelDateValue.Size = new System.Drawing.Size(69, 19);
            this.toolStripStatusLabelDateValue.Text = "01/07/2012";
            // 
            // toolStripStatusLabelHour
            // 
            this.toolStripStatusLabelHour.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelHour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelHour.Name = "toolStripStatusLabelHour";
            this.toolStripStatusLabelHour.Size = new System.Drawing.Size(37, 19);
            this.toolStripStatusLabelHour.Text = "Hora:";
            // 
            // toolStripStatusLabelHourValue
            // 
            this.toolStripStatusLabelHourValue.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelHourValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelHourValue.Name = "toolStripStatusLabelHourValue";
            this.toolStripStatusLabelHourValue.Size = new System.Drawing.Size(53, 19);
            this.toolStripStatusLabelHourValue.Text = "11:45:00";
            // 
            // toolStripStatusLabelSpace
            // 
            this.toolStripStatusLabelSpace.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelSpace.Name = "toolStripStatusLabelSpace";
            this.toolStripStatusLabelSpace.Size = new System.Drawing.Size(486, 19);
            this.toolStripStatusLabelSpace.Spring = true;
            // 
            // toolStripStatusLabelVersion
            // 
            this.toolStripStatusLabelVersion.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelVersion.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            this.toolStripStatusLabelVersion.Size = new System.Drawing.Size(116, 19);
            this.toolStripStatusLabelVersion.Text = "Versão do Sistema:";
            // 
            // toolStripStatusLabelVersionValue
            // 
            this.toolStripStatusLabelVersionValue.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabelVersionValue.Name = "toolStripStatusLabelVersionValue";
            this.toolStripStatusLabelVersionValue.Size = new System.Drawing.Size(31, 19);
            this.toolStripStatusLabelVersionValue.Text = "1.0.0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::IFSP.ADS.SiPDV.View.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 662);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiPDV - Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem tablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOperator;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOperatorValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateValue;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHour;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHourValue;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSpace;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersionValue;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorsToolStripMenuItem;

    }
}