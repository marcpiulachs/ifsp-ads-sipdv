using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using IFSP.ADS.SiPDV.Config;

namespace IFSP.ADS.SiPDV.Database
{
    public class BaseDataAccess : IDisposable
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlDataAdapter sqlDataAdapter;

        public BaseDataAccess()
        {
            try
            {
                this.sqlConnection = new SqlConnection(Configuration.GetConnectionString());
                this.sqlConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region -Public Methods-

        public void Dispose()
        {
            try
            {
                if (this.sqlConnection.State == ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
