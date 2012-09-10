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

        public void InsertOperator(string code, string name, string password, int status)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, code);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorNameParam, name);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorPasswordParam, password);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorStatusParam, status);

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

        public void UpdateOperator(int id, string code, string name, string password)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorUpdateSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, code);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorNameParam, name);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorPasswordParam, password);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorIdParam, id);

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

        public void UpdateOperatorStatus(string code, int status)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorUpdateStatusSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, code);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorStatusParam, status);

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

        public DataTable GetAllOperators()
        {
            DataTable dtOperators;

            try
            {
                dtOperators = new DataTable(DatabaseConstants.OperatorTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorGetAllSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtOperators);

                return dtOperators;
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
                this.sqlDataAdapter.Dispose();
                this.sqlCommand.Dispose();
            }
        }

        public DataTable GetOperatorsByCode(string code)
        {
            DataTable dtOperators;

            try
            {
                dtOperators = new DataTable(DatabaseConstants.OperatorTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorGetByCodeSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, code);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtOperators);

                return dtOperators;
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
                this.sqlDataAdapter.Dispose();
                this.sqlCommand.Dispose();
            }
        }

        public DataTable GetOperatorsByName(string name)
        {
            DataTable dtOperators;

            try
            {
                dtOperators = new DataTable(DatabaseConstants.OperatorTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorGetByNameSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorNameParam, "%" + name + "%");

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtOperators);

                return dtOperators;
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
                this.sqlDataAdapter.Dispose();
                this.sqlCommand.Dispose();
            }
        }

        #endregion
    }
}
