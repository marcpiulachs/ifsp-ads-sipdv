using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

using IFSP.ADS.SiPDV.Framework;

namespace IFSP.ADS.SiPDV.Config
{
    public class Configuration
    {
        #region -Public Static Methods-

        public static string ReadConfigurationValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static void WriteConfigurationValue(string key, string value)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection(ConfigurationConstants.DefaultSection);
        }

        public static string GetConnectionString()
        {
            return string.Format(ConfigurationConstants.ConnectionString, 
                                 ReadConfigurationValue(ConfigurationConstants.DataSource), 
                                 ReadConfigurationValue(ConfigurationConstants.InitialCatalog), 
                                 ReadConfigurationValue(ConfigurationConstants.UserId), 
                                 ReadConfigurationValue(ConfigurationConstants.Password));
        }

        #endregion
    }
}
