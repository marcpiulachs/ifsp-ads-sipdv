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
    public class SaleDataAccess : BaseDataAccess
    {
        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public SaleDataAccess()
        {
 
        }

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Busca o id de determinada venda.
        /// </summary>
        /// <param name="operatorId">Id do operador que realizou a venda</param>
        /// <param name="dateTime">Data e hora que a venda foi realizada</param>
        /// <returns>Retorna o id da venda</returns>
        public int GetId(int operatorId, DateTime dateTime)
        {
            object dbReturn;

            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.SaleGetIdSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleIdOperatorParam, operatorId);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeParam, dateTime);

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
        /// Insere uma nova venda no banco de dados.
        /// </summary>
        /// <param name="operatorId">Id do operador que realizou a venda</param>
        /// <param name="dateTime">Data e hora da venda</param>
        /// <param name="subtotal">Subtotal da venda</param>
        /// <param name="discount">Desconto da venda</param>
        /// <param name="total">Total da venda</param>
        public void InsertSale(int operatorId, DateTime dateTime, float subtotal, float discount, float total)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.SaleInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleIdOperatorParam, operatorId);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeParam, dateTime);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleSubtotalParam, subtotal);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDiscountParam, discount);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleTotalParam, total);

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
        /// Insere um produto vendido de determinada venda.
        /// </summary>
        /// <param name="saleId">Id da venda</param>
        /// <param name="productId">Id do produto</param>
        /// <param name="quantity">Quantidade vendida deste produto</param>
        /// <param name="costPrice">Preço de custo deste produto</param>
        /// <param name="salePrice">Preço de venda deste produto</param>
        public void InsertSaleProducts(int saleId, int productId, int quantity, float costPrice, float salePrice)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.SaleProductInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleProductIdSaleParam, saleId);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleProductIdProductParam, productId);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleProductQuantityParam, quantity);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleProductCostPriceParam, costPrice);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleProductSalePriceParam, salePrice);

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
        /// Busca todas as vendas realizadas entre duas datas.
        /// </summary>
        /// <param name="dateTimeInitial">Data inicial</param>
        /// <param name="dateTimeFinal">Data final</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetSaleByDate(DateTime dateTimeInitial, DateTime dateTimeFinal)
        {
            DataTable dtSales;

            try
            {
                dtSales = new DataTable(DatabaseConstants.SaleTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.SaleGetByDateSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeInitialParam, dateTimeInitial);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeFinalParam, dateTimeFinal);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtSales);

                return dtSales;
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
