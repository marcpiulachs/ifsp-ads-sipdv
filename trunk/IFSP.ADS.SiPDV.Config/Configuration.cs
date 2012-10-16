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

        /// <summary>
        /// Lê um valor do arquivo de configurações.
        /// </summary>
        /// <param name="key">Chave</param>
        /// <returns>Valor</returns>
        public static string ReadConfigurationValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        /// <summary>
        /// Escreve um valor no arquivo de configurações.
        /// </summary>
        /// <param name="key">Chave</param>
        /// <param name="value">Valor</param>
        public static void WriteConfigurationValue(string key, string value)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection(ConfigurationConstants.DefaultSection);
        }

        /// <summary>
        /// Constrói a string de conexão com o banco de dados de acordo com valores definidos no arquivo de configurações.
        /// </summary>
        /// <returns>Retorna a string de conexão com o banco de dados</returns>
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
