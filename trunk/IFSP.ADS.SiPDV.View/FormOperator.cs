using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using IFSP.ADS.SiPDV.Business;
using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormOperator : Form
    {
        #region -Private Attributes-

        private OperatorBusiness operatorBusiness;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormOperator()
        {
            InitializeComponent();

            this.operatorBusiness = new OperatorBusiness();
        }

        #endregion

        #region -Events-

        private void FormOperator_Load(object sender, EventArgs e)
        {
            HidePasswordFields();
            LoadAllOperators();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ShowPasswordFields();
            ClearFields();
            this.dataGridViewOperators.ClearSelection();
            this.textBoxCode.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.textBoxPassword.Text == this.textBoxConfirmPassword.Text)
            {
                SaveOperator();
                LoadAllOperators();
            }
            else
            {
                MessageBox.Show(this, Resources.OperatorPasswordWarning, Resources.Warning, MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                this.textBoxPassword.Text = string.Empty;
                this.textBoxConfirmPassword.Text = string.Empty;

                this.textBoxPassword.Focus();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show(this, Resources.OperatorDeleteQuestion, Resources.Question,
                                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                          MessageBoxDefaultButton.Button2))
            {
                DeleteOperator();
                LoadAllOperators();
            }
        }

        private void textBoxSearchCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchCode.Text))
                {
                    LoadOperatorsByCode();
                }
            }
        }

        private void textBoxSearchCode_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchCode.Text.Length == 0)
            {
                LoadAllOperators();
            }
        }

        private void textBoxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
                {
                    LoadOperatorsByName();
                }
            }
        }

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            if (this.textBoxSearchName.Text.Length == 0)
            {
                LoadAllOperators();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxSearchCode.Text))
            {
                LoadOperatorsByCode();
            }
            else if (!string.IsNullOrWhiteSpace(this.textBoxSearchName.Text))
            {
                LoadOperatorsByName();
            }
            else
            {
                LoadAllOperators();
            }
        }

        private void dataGridViewOperators_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewOperators.SelectedRows.Count == 1)
            {
                HidePasswordFields();
            }

            ClearFields();
            FillFields();
        }

        #endregion

        #region -Private Methods-

        /// <summary>
        /// Limpa os campos do formulário de operador.
        /// </summary>
        private void ClearFields()
        {
            this.textBoxCode.Text = string.Empty;
            this.textBoxName.Text = string.Empty;
            this.textBoxPassword.Text = string.Empty;
            this.textBoxConfirmPassword.Text = string.Empty;
        }

        /// <summary>
        /// Preenche os campos do formulário de operador com os dados do operador selecionado.
        /// </summary>
        private void FillFields()
        {
            if (this.dataGridViewOperators.SelectedRows.Count == 1)
            {
                this.textBoxCode.Text = this.dataGridViewOperators.SelectedRows[0].Cells[1].Value.ToString();
                this.textBoxName.Text = this.dataGridViewOperators.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        /// <summary>
        /// Esconde os campos de senha do formulário.
        /// </summary>
        private void HidePasswordFields()
        {
            this.labelPassword.Visible = false;
            this.textBoxPassword.Visible = false;
            this.labelConfirmPassword.Visible = false;
            this.textBoxConfirmPassword.Visible = false;
        }

        /// <summary>
        /// Exibe os campos de senha do formulário.
        /// </summary>
        private void ShowPasswordFields()
        {
            this.labelPassword.Visible = true;
            this.textBoxPassword.Visible = true;
            this.labelConfirmPassword.Visible = true;
            this.textBoxConfirmPassword.Visible = true;
        }

        /// <summary>
        /// Carrega todos os operadores.
        /// </summary>
        private void LoadAllOperators()
        {
            try
            {
                this.dataGridViewOperators.DataSource = this.operatorBusiness.GetAllOperators();
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        /// <summary>
        /// Carrega operador pelo código.
        /// </summary>
        private void LoadOperatorsByCode()
        {
            try
            {
                this.dataGridViewOperators.DataSource = this.operatorBusiness.GetOperatorByCode(this.textBoxSearchCode.Text);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        /// <summary>
        /// Carrega operadores pelo nome.
        /// </summary>
        private void LoadOperatorsByName()
        {
            try
            {
                this.dataGridViewOperators.DataSource = this.operatorBusiness.GetOperatorsByName(this.textBoxSearchName.Text);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
        }

        /// <summary>
        /// Salva os dados do operador.
        /// </summary>
        private void SaveOperator()
        {
            try
            {
                Operator oper = new Operator();

                if (this.dataGridViewOperators.SelectedRows.Count == 1)
                {
                    oper.Id = int.Parse(this.dataGridViewOperators.SelectedRows[0].Cells[0].Value.ToString());
                }

                oper.Code = this.textBoxCode.Text;
                oper.Name = this.textBoxName.Text;
                oper.Password = this.textBoxPassword.Text;
                oper.Status = 1;

                this.operatorBusiness.InsertUpdateOperator(oper);

                MessageBox.Show(this, Resources.OperatorSaveSuccess, Resources.Success, 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.OperatorSaveError, Resources.Error, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deleta um operador.
        /// </summary>
        private void DeleteOperator()
        {
            try
            {
                Operator oper = new Operator();
                oper.Code = this.textBoxCode.Text;

                this.operatorBusiness.DeleteOperator(oper);

                MessageBox.Show(this, Resources.OperatorDeleteSuccess, Resources.Success, MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.OperatorDeleteError, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
