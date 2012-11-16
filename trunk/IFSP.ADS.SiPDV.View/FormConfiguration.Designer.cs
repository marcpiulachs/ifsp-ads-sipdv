namespace IFSP.ADS.SiPDV.View
{
    partial class FormConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDatabase = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.labelDataSource = new System.Windows.Forms.Label();
            this.labelInitialCatalog = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxDataSource = new System.Windows.Forms.TextBox();
            this.textBoxInitialCatalog = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageDatabase.SuspendLayout();
            this.tableLayoutPanelDatabase.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageDatabase);
            this.tabControl.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 418);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageDatabase
            // 
            this.tabPageDatabase.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageDatabase.Controls.Add(this.buttonSave);
            this.tabPageDatabase.Controls.Add(this.tableLayoutPanelDatabase);
            this.tabPageDatabase.Location = new System.Drawing.Point(4, 26);
            this.tabPageDatabase.Name = "tabPageDatabase";
            this.tabPageDatabase.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatabase.Size = new System.Drawing.Size(592, 388);
            this.tabPageDatabase.TabIndex = 0;
            this.tabPageDatabase.Text = "Banco de Dados";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Save;
            this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSave.Location = new System.Drawing.Point(445, 342);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 40);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanelDatabase
            // 
            this.tableLayoutPanelDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelDatabase.ColumnCount = 2;
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelDatabase.Controls.Add(this.labelDataSource, 0, 0);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelInitialCatalog, 0, 1);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelUserId, 0, 2);
            this.tableLayoutPanelDatabase.Controls.Add(this.labelPassword, 0, 3);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxDataSource, 1, 0);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxInitialCatalog, 1, 1);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxUserId, 1, 2);
            this.tableLayoutPanelDatabase.Controls.Add(this.textBoxPassword, 1, 3);
            this.tableLayoutPanelDatabase.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanelDatabase.Name = "tableLayoutPanelDatabase";
            this.tableLayoutPanelDatabase.RowCount = 4;
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDatabase.Size = new System.Drawing.Size(580, 120);
            this.tableLayoutPanelDatabase.TabIndex = 0;
            // 
            // labelDataSource
            // 
            this.labelDataSource.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDataSource.AutoSize = true;
            this.labelDataSource.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataSource.Location = new System.Drawing.Point(42, 7);
            this.labelDataSource.Name = "labelDataSource";
            this.labelDataSource.Size = new System.Drawing.Size(158, 16);
            this.labelDataSource.TabIndex = 0;
            this.labelDataSource.Text = "Fonte de Dados:";
            // 
            // labelInitialCatalog
            // 
            this.labelInitialCatalog.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelInitialCatalog.AutoSize = true;
            this.labelInitialCatalog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialCatalog.Location = new System.Drawing.Point(102, 37);
            this.labelInitialCatalog.Name = "labelInitialCatalog";
            this.labelInitialCatalog.Size = new System.Drawing.Size(98, 16);
            this.labelInitialCatalog.TabIndex = 1;
            this.labelInitialCatalog.Text = "Catálogo:";
            // 
            // labelUserId
            // 
            this.labelUserId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserId.Location = new System.Drawing.Point(112, 67);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(88, 16);
            this.labelUserId.TabIndex = 2;
            this.labelUserId.Text = "Usuário:";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(132, 97);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 16);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Senha:";
            // 
            // textBoxDataSource
            // 
            this.textBoxDataSource.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDataSource.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataSource.Location = new System.Drawing.Point(206, 3);
            this.textBoxDataSource.MaxLength = 30;
            this.textBoxDataSource.Name = "textBoxDataSource";
            this.textBoxDataSource.Size = new System.Drawing.Size(305, 23);
            this.textBoxDataSource.TabIndex = 4;
            // 
            // textBoxInitialCatalog
            // 
            this.textBoxInitialCatalog.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxInitialCatalog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInitialCatalog.Location = new System.Drawing.Point(206, 33);
            this.textBoxInitialCatalog.MaxLength = 30;
            this.textBoxInitialCatalog.Name = "textBoxInitialCatalog";
            this.textBoxInitialCatalog.Size = new System.Drawing.Size(305, 23);
            this.textBoxInitialCatalog.TabIndex = 5;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUserId.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserId.Location = new System.Drawing.Point(206, 63);
            this.textBoxUserId.MaxLength = 30;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(305, 23);
            this.textBoxUserId.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(206, 93);
            this.textBoxPassword.MaxLength = 30;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(305, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "FormConfiguration";
            this.Text = "SiPDV - Configurações";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageDatabase.ResumeLayout(false);
            this.tableLayoutPanelDatabase.ResumeLayout(false);
            this.tableLayoutPanelDatabase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDatabase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDatabase;
        private System.Windows.Forms.Label labelDataSource;
        private System.Windows.Forms.Label labelInitialCatalog;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxDataSource;
        private System.Windows.Forms.TextBox textBoxInitialCatalog;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSave;
    }
}