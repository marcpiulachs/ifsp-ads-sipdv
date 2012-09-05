using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class ConfigurationConstants
    {
        #region -Constants-

        private const string DEFAULT_SECTION = "appSettings";

        private const string CONNECTION_STRING = "Data Source = {0}; Initial Catalog = {1}; User Id = {2}; Password = {3};";
        private const string DATA_SOURCE = "DataSource";
        private const string INITIAL_CATALOG = "InitialCatalog";
        private const string USER_ID = "UserId";
        private const string PASSWORD = "Password";

        #endregion

        #region -Public Properties-

        public static string DefaultSection
        {
            get { return DEFAULT_SECTION; }
        }

        public static string ConnectionString
        {
            get { return CONNECTION_STRING; }
        }

        public static string DataSource
        {
            get { return DATA_SOURCE; }
        }

        public static string InitialCatalog
        {
            get { return INITIAL_CATALOG; }
        }

        public static string UserId
        {
            get { return USER_ID; }
        }

        public static string Password
        {
            get { return PASSWORD; }
        }

        #endregion
    }
}
