using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;

namespace IFSP.ADS.SiPDV.Database
{
    public class OperatorDataAccess : BaseDataAccess
    {
        #region -Constructor-

        public OperatorDataAccess()
        {
 
        }

        #endregion

        #region -Public Methods-

        public void InsertOperator(Operator oper)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, oper.Code);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorNameParam, oper.Name);

                this.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logging.Error(DatabaseConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
            finally
            {
                this.sqlCommand.Dispose();
            }
        }

        #endregion
    }
}
