using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;

namespace IFSP.ADS.SiPDV.Database
{
    public class ProductDataAccess : BaseDataAccess
    {
        public ProductDataAccess()
        {
            
        }

        public int GetId(long barCode)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductGetIdSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

                return (int)this.sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void InsertProduct(long barCode, string name, string description, string measurementUnit, 
                                  int quantity, DateTime dateTime, float costPrice, float salePrice)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductNameParam, name);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductDescriptionParam, description);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductMeasurementUnitParam, measurementUnit);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductQuantityParam, quantity);

                this.sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                Logging.Error(DatabaseConstants.ProjectName, sqlex.Message);

                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.sqlCommand.Dispose();
            }
        }

        public void UpdateProduct()
        {
 
        }

        public void DeleteProduct()
        {
 
        }

        public DataTable GetAllProducts()
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductGetAllSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
            }
            catch (SqlException sqlex)
            {
                Logging.Error(DatabaseConstants.ProjectName, sqlex.Message);

                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.sqlDataAdapter.Dispose();
                this.sqlCommand.Dispose();
            }
        }

        public DataTable GetProductsByBarCode(long barCode)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductGetByBarCodeSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
            }
            catch (SqlException sqlex)
            {
                Logging.Error(DatabaseConstants.ProjectName, sqlex.Message);

                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.sqlDataAdapter.Dispose();
                this.sqlCommand.Dispose();
            }
        }

        public DataTable GetProductsByName(string name)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductGetByNameSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductNameParam, "%" + name + "%");

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
            }
            catch (SqlException sqlex)
            {
                Logging.Error(DatabaseConstants.ProjectName, sqlex.Message);

                throw sqlex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.sqlDataAdapter.Dispose();
                this.sqlCommand.Dispose();
            }
        }
    }
}
