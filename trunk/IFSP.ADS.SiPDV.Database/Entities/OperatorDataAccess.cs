using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using IFSP.ADS.SiPDV.Framework;

namespace IFSP.ADS.SiPDV.Database
{
    public class OperatorDataAccess : BaseDataAccess
    {
        public OperatorDataAccess()
        {
 
        }

        public void InsertOperator(Operator ope)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, ope.Code);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorNameParam, ope.Name);

                this.sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
