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

        public SaleDataAccess()
        {
 
        }

        #endregion

        #region -Public Methods-

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

        #endregion
    }
}
