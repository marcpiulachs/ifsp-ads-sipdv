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
        #region -Protected Attributes-

        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlDataAdapter sqlDataAdapter;

        #endregion

        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
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

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Fecha a conexão com o banco de dados.
        /// </summary>
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
