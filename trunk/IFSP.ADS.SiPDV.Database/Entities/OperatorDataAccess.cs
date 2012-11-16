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

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public OperatorDataAccess()
        {
 
        }

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Valida o login do operador.
        /// </summary>
        /// <param name="code">Código do operador</param>
        /// <param name="password">Senha do operador</param>
        /// <returns>Retorna o id do operador em caso de sucesso, ou 0 caso o login não seja válido</returns>
        public int Login(string code, string password)
        {
            object dbReturn;

            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorLoginSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, code);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorPasswordParam, password);

                dbReturn = this.sqlCommand.ExecuteScalar();

                if (dbReturn != null)
                {
                    return (int)dbReturn;
                }
                else
                {
                    return 0;
                }
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

        /// <summary>
        /// Insere um novo operador no banco de dados.
        /// </summary>
        /// <param name="code">Código do operador</param>
        /// <param name="name">Nome do operador</param>
        /// <param name="password">Senha do operador</param>
        /// <param name="status">Status do operador</param>
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

        /// <summary>
        /// Atualiza um operador no banco de dados.
        /// </summary>
        /// <param name="id">Id do operador</param>
        /// <param name="code">Código do operador</param>
        /// <param name="name">Nome do operador</param>
        /// <param name="password">Senha do operador</param>
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

        /// <summary>
        /// Atualiza o status do operador (1 - ativo, 0 - inativo).
        /// </summary>
        /// <param name="code">Código do operador</param>
        /// <param name="status">Status do operador</param>
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

        /// <summary>
        /// Busca o operador pelo id.
        /// </summary>
        /// <param name="id">Id do operador</param>
        /// <returns>Retorna um DataTable contendo o resultado da busca realizada</returns>
        public DataTable GetOperatorById(int id)
        {
            DataTable dtOperator;

            try
            {
                dtOperator = new DataTable(DatabaseConstants.OperatorTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorGetByIdSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorIdParam, id);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtOperator);

                return dtOperator;
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

        /// <summary>
        /// Busca o operador pelo código.
        /// </summary>
        /// <param name="code">Código do operador</param>
        /// <returns>Retorna um DataTable contendo o resultado da busca realizada</returns>
        public DataTable GetOperatorByCode(string code)
        {
            DataTable dtOperator;

            try
            {
                dtOperator = new DataTable(DatabaseConstants.OperatorTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.OperatorGetByCodeSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.OperatorCodeParam, code);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtOperator);

                return dtOperator;
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

        /// <summary>
        /// Busca os operadores pelo nome.
        /// </summary>
        /// <param name="name">Nome dos operadores</param>
        /// <returns>Retorna um DataTable contendo o resultado da busca realizada</returns>
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

        /// <summary>
        /// Busca todos os operadores.
        /// </summary>
        /// <returns>Retorna um DataTable contendo o resultado da busca realizada</returns>
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

        #endregion
    }
}
