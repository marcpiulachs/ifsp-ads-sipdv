using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using IFSP.ADS.SiPDV.Config;
using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;
using IFSP.ADS.SiPDV.View.Properties;

namespace IFSP.ADS.SiPDV.View
{
    public partial class FormConfiguration : Form
    {
        #region -Private Attributes-



        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public FormConfiguration()
        {
            InitializeComponent();
        }

        #endregion

        #region -Events-

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            LoadDatabaseConfiguration();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDatabaseConfiguration();
        }

        #endregion

        #region -Private Methods-

        private void LoadDatabaseConfiguration()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                this.textBoxDataSource.Text = Configuration.ReadConfigurationValue(ConfigurationConstants.DataSource);
                this.textBoxInitialCatalog.Text = Configuration.ReadConfigurationValue(ConfigurationConstants.InitialCatalog);
                this.textBoxUserId.Text = Configuration.ReadConfigurationValue(ConfigurationConstants.UserId);
                this.textBoxPassword.Text = Configuration.ReadConfigurationValue(ConfigurationConstants.Password);
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void SaveDatabaseConfiguration()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                if (!string.IsNullOrWhiteSpace(this.textBoxDataSource.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBoxInitialCatalog.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBoxUserId.Text) &&
                    !string.IsNullOrWhiteSpace(this.textBoxPassword.Text))
                {
                    Configuration.WriteConfigurationValue(ConfigurationConstants.DataSource, this.textBoxDataSource.Text);
                    Configuration.WriteConfigurationValue(ConfigurationConstants.InitialCatalog, this.textBoxInitialCatalog.Text);
                    Configuration.WriteConfigurationValue(ConfigurationConstants.UserId, this.textBoxUserId.Text);
                    Configuration.WriteConfigurationValue(ConfigurationConstants.Password, this.textBoxPassword.Text);

                    Thread.Sleep(1000);

                    MessageBox.Show(this, Resources.ConfigurationDatabaseSaveSuccess, Resources.Success, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, Resources.ConfigurationDatabaseEmptyFields, Resources.Warning, 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(ViewConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                MessageBox.Show(this, Resources.ConfigurationDatabaseSaveError, Resources.Error, 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion
    }
}
