namespace IFSP.ADS.SiPDV.View
{
    partial class FormOperator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperator));
            this.groupBoxOperator = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tableLayoutPanelOperator = new System.Windows.Forms.TableLayoutPanel();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBoxSearchOperators = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSearchOperators = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchCode = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchCode = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.groupBoxOperator.SuspendLayout();
            this.tableLayoutPanelOperator.SuspendLayout();
            this.groupBoxSearchOperators.SuspendLayout();
            this.tableLayoutPanelSearchOperators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOperator
            // 
            this.groupBoxOperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOperator.Controls.Add(this.buttonDelete);
            this.groupBoxOperator.Controls.Add(this.buttonSave);
            this.groupBoxOperator.Controls.Add(this.buttonNew);
            this.groupBoxOperator.Controls.Add(this.tableLayoutPanelOperator);
            this.groupBoxOperator.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOperator.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOperator.Name = "groupBoxOperator";
            this.groupBoxOperator.Size = new System.Drawing.Size(760, 220);
            this.groupBoxOperator.TabIndex = 0;
            this.groupBoxOperator.TabStop = false;
            this.groupBoxOperator.Text = "Cadastrar Operador";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = global::IFSP.ADS.SiPDV.View.Properties.Resources.Cancel;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(613, 113);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(141, 40);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Excluir";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
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
            // tableLayoutPanelOperator
            // 
            this.tableLayoutPanelOperator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelOperator.ColumnCount = 2;
            this.tableLayoutPanelOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelOperator.Controls.Add(this.labelCode, 0, 0);
            this.tableLayoutPanelOperator.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelOperator.Controls.Add(this.textBoxCode, 1, 0);
            this.tableLayoutPanelOperator.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelOperator.Controls.Add(this.labelPassword, 0, 2);
            this.tableLayoutPanelOperator.Controls.Add(this.textBoxPassword, 1, 2);
            this.tableLayoutPanelOperator.Controls.Add(this.labelConfirmPassword, 0, 3);
            this.tableLayoutPanelOperator.Controls.Add(this.textBoxConfirmPassword, 1, 3);
            this.tableLayoutPanelOperator.Location = new System.Drawing.Point(7, 21);
            this.tableLayoutPanelOperator.Name = "tableLayoutPanelOperator";
            this.tableLayoutPanelOperator.RowCount = 6;
            this.tableLayoutPanelOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelOperator.Size = new System.Drawing.Size(600, 180);
            this.tableLayoutPanelOperator.TabIndex = 0;
            // 
            // labelCode
            // 
            this.labelCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(129, 6);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(78, 16);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Código:";
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
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(213, 3);
            this.textBoxCode.MaxLength = 11;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(115, 23);
            this.textBoxCode.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(213, 32);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(305, 23);
            this.textBoxName.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(139, 64);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 16);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Senha:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(213, 61);
            this.textBoxPassword.MaxLength = 35;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(120, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(29, 93);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(178, 16);
            this.labelConfirmPassword.TabIndex = 6;
            this.labelConfirmPassword.Text = "Confirme a Senha:";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(213, 90);
            this.textBoxConfirmPassword.MaxLength = 35;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(120, 23);
            this.textBoxConfirmPassword.TabIndex = 7;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // groupBoxSearchOperators
            // 
            this.groupBoxSearchOperators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchOperators.Controls.Add(this.tableLayoutPanelSearchOperators);
            this.groupBoxSearchOperators.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearchOperators.Location = new System.Drawing.Point(12, 238);
            this.groupBoxSearchOperators.Name = "groupBoxSearchOperators";
            this.groupBoxSearchOperators.Size = new System.Drawing.Size(760, 70);
            this.groupBoxSearchOperators.TabIndex = 1;
            this.groupBoxSearchOperators.TabStop = false;
            this.groupBoxSearchOperators.Text = "Buscar Operadores";
            // 
            // tableLayoutPanelSearchOperators
            // 
            this.tableLayoutPanelSearchOperators.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSearchOperators.ColumnCount = 5;
            this.tableLayoutPanelSearchOperators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelSearchOperators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSearchOperators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelSearchOperators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanelSearchOperators.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelSearchOperators.Controls.Add(this.labelSearchCode, 0, 0);
            this.tableLayoutPanelSearchOperators.Controls.Add(this.labelSearchName, 2, 0);
            this.tableLayoutPanelSearchOperators.Controls.Add(this.textBoxSearchCode, 1, 0);
            this.tableLayoutPanelSearchOperators.Controls.Add(this.textBoxSearchName, 3, 0);
            this.tableLayoutPanelSearchOperators.Controls.Add(this.buttonSearch, 4, 0);
            this.tableLayoutPanelSearchOperators.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanelSearchOperators.Name = "tableLayoutPanelSearchOperators";
            this.tableLayoutPanelSearchOperators.RowCount = 1;
            this.tableLayoutPanelSearchOperators.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearchOperators.Size = new System.Drawing.Size(746, 30);
            this.tableLayoutPanelSearchOperators.TabIndex = 0;
            // 
            // labelSearchCode
            // 
            this.labelSearchCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchCode.AutoSize = true;
            this.labelSearchCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchCode.Location = new System.Drawing.Point(12, 7);
            this.labelSearchCode.Name = "labelSearchCode";
            this.labelSearchCode.Size = new System.Drawing.Size(78, 16);
            this.labelSearchCode.TabIndex = 0;
            this.labelSearchCode.Text = "Código:";
            // 
            // labelSearchName
            // 
            this.labelSearchName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchName.Location = new System.Drawing.Point(255, 7);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(58, 16);
            this.labelSearchName.TabIndex = 2;
            this.labelSearchName.Text = "Nome:";
            // 
            // textBoxSearchCode
            // 
            this.textBoxSearchCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearchCode.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCode.Location = new System.Drawing.Point(96, 3);
            this.textBoxSearchCode.MaxLength = 11;
            this.textBoxSearchCode.Name = "textBoxSearchCode";
            this.textBoxSearchCode.Size = new System.Drawing.Size(115, 23);
            this.textBoxSearchCode.TabIndex = 1;
            this.textBoxSearchCode.TextChanged += new System.EventHandler(this.textBoxSearchCode_TextChanged);
            this.textBoxSearchCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchCode_KeyDown);
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSearchName.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchName.Location = new System.Drawing.Point(319, 3);
            this.textBoxSearchName.MaxLength = 30;
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(305, 23);
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
            this.buttonSearch.Location = new System.Drawing.Point(636, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(107, 24);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.AllowUserToAddRows = false;
            this.dataGridViewOperators.AllowUserToDeleteRows = false;
            this.dataGridViewOperators.AllowUserToResizeRows = false;
            this.dataGridViewOperators.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOperators.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperators.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewOperators.Location = new System.Drawing.Point(12, 314);
            this.dataGridViewOperators.MultiSelect = false;
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            this.dataGridViewOperators.ReadOnly = true;
            this.dataGridViewOperators.RowHeadersVisible = false;
            this.dataGridViewOperators.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOperators.Size = new System.Drawing.Size(760, 236);
            this.dataGridViewOperators.TabIndex = 2;
            this.dataGridViewOperators.SelectionChanged += new System.EventHandler(this.dataGridViewOperators_SelectionChanged);
            // 
            // FormOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBoxOperator);
            this.Controls.Add(this.groupBoxSearchOperators);
            this.Controls.Add(this.dataGridViewOperators);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormOperator";
            this.Text = "SiPDV - Operadores";
            this.Load += new System.EventHandler(this.FormOperator_Load);
            this.groupBoxOperator.ResumeLayout(false);
            this.tableLayoutPanelOperator.ResumeLayout(false);
            this.tableLayoutPanelOperator.PerformLayout();
            this.groupBoxSearchOperators.ResumeLayout(false);
            this.tableLayoutPanelSearchOperators.ResumeLayout(false);
            this.tableLayoutPanelSearchOperators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOperator;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOperator;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxSearchOperators;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchOperators;
        private System.Windows.Forms.Label labelSearchCode;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchCode;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewOperators;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
    }
}