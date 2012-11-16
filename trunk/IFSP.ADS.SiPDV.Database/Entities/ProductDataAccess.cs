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
    public class ProductDataAccess : BaseDataAccess
    {
        #region -Constructor-

        /// <summary>
        /// Construtor padrão.
        /// </summary>
        public ProductDataAccess()
        {
            
        }

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Busca o id do produto.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna o id do produto</returns>
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
        /// Insere um novo produto no banco de dados.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <param name="name">Nome do produto</param>
        /// <param name="description">Descrição do produto</param>
        /// <param name="measurementUnit">Unidade de medida do produto</param>
        /// <param name="stockQuantity">Quantidade em estoque do produto</param>
        /// <param name="status">Status do produto</param>
        public void InsertProduct(long barCode, string name, string description, string measurementUnit, double stockQuantity, int status)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductNameParam, name);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductDescriptionParam, description);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductMeasurementUnitParam, measurementUnit);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductStockQuantityParam, stockQuantity);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductStatusParam, status);

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
        /// Insere um novo preço de um produto.
        /// </summary>
        /// <param name="productId">Id do produto</param>
        /// <param name="dateTime">Data do preço do produto</param>
        /// <param name="costPrice">Preço de custo</param>
        /// <param name="salePrice">Preço de venda</param>
        public void InsertPrice(int productId, DateTime dateTime, float costPrice, float salePrice)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.PriceInsertSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.PriceIdProductParam, productId);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.PriceDateTimeParam, dateTime);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.PriceCostPriceParam, costPrice);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.PriceSalePriceParam, salePrice);

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
        /// Atualiza um produto no banco de dados.
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <param name="barCode">Código de barras do produto</param>
        /// <param name="name">Nome do produto</param>
        /// <param name="description">Descrição do produto</param>
        /// <param name="measurementUnit">Unidade de medida do produto</param>
        /// <param name="status">Status do produto</param>
        public void UpdateProduct(int id, long barCode, string name, string description, string measurementUnit, int status)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductUpdateSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductNameParam, name);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductDescriptionParam, description);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductMeasurementUnitParam, measurementUnit);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductStatusParam, status);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductIdParam, id);

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
        /// Atualiza a quantidade em estoque de um produto.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <param name="stockQuantity">Quantidade em estoque do produto</param>
        public void UpdateProductStockQuantity(long barCode, double stockQuantity)
        {
            try
            {
                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductUpdateQuantitySql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductStockQuantityParam, stockQuantity);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

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
        /// Busca um produto para venda.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductSale(long barCode)
        {
            DataTable dtProduct;

            try
            {
                dtProduct = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductSaleGetSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProduct);

                return dtProduct;
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
        /// Busca o produto pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductByBarCode(long barCode)
        {
            DataTable dtProduct;

            try
            {
                dtProduct = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductGetByBarCodeSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProduct);

                return dtProduct;
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
        /// Busca os produtos pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
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
        /// Busca todos os produtos.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
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
        /// Busca o produto para venda pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductSaleByBarCode(long barCode)
        {
            DataTable dtProduct;

            try
            {
                dtProduct = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductSaleGetByBarCodeSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProduct);

                return dtProduct;
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
        /// Busca os produtos para venda pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsSaleByName(string name)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductSaleGetByNameSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductNameParam, "%" + name + "%");

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
        /// Busca todos os produtos para venda.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetAllProductsSale()
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductSaleGetAllSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
        /// Busca o produto para estoque pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductStockByBarCode(long barCode)
        {
            DataTable dtProduct;

            try
            {
                dtProduct = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductStockGetByBarCodeSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductBarCodeParam, barCode);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProduct);

                return dtProduct;
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
        /// Busca os produtos para estoque pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsStockByName(string name)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductStockGetByNameSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductNameParam, "%" + name + "%");

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
        /// Busca todos os produtos para estoque.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetAllProductsStock()
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductStockGetAllSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
        /// Busca os produtos que estão em falta no estoque, de acordo com o mínimo informado.
        /// </summary>
        /// <param name="stockQuantity">Quantidade mínima de produtos no estoque</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsStockMissing(double stockQuantity)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductStockMissingSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.ProductStockQuantityParam, stockQuantity);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
        /// Busca os produtos mais vendidos em determinado período.
        /// </summary>
        /// <param name="dateTimeInitial">Data inicial</param>
        /// <param name="dateTimeFinal">Data final</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsBestSellers(DateTime dateTimeInitial, DateTime dateTimeFinal)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductBestSellersSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeInitialParam, dateTimeInitial);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeFinalParam, dateTimeFinal);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
        /// Busca os produtos menos vendidos em determinado período.
        /// </summary>
        /// <param name="dateTimeInitial">Data inicial</param>
        /// <param name="dateTimeFinal">Data final</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsWorstSellers(DateTime dateTimeInitial, DateTime dateTimeFinal)
        {
            DataTable dtProducts;

            try
            {
                dtProducts = new DataTable(DatabaseConstants.ProductTable);

                this.sqlCommand = new SqlCommand(DatabaseConstants.ProductWorstSellersSql, this.sqlConnection);
                this.sqlCommand.CommandType = CommandType.Text;

                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeInitialParam, dateTimeInitial);
                this.sqlCommand.Parameters.AddWithValue(DatabaseConstants.SaleDateTimeFinalParam, dateTimeFinal);

                this.sqlDataAdapter = new SqlDataAdapter(this.sqlCommand);
                this.sqlDataAdapter.Fill(dtProducts);

                return dtProducts;
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
