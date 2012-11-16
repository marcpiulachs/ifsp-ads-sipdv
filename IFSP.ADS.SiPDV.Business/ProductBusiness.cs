using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

using IFSP.ADS.SiPDV.Database;
using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;

namespace IFSP.ADS.SiPDV.Business
{
    public class ProductBusiness
    {
        #region -Private Attributes-

        private ProductDataAccess productDataAccess;

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Insere um novo produto ou atualiza caso ele já exista.
        /// </summary>
        /// <param name="product">Produto a ser inserido ou atualizado</param>
        public void InsertUpdateProduct(Product product)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    if (product.Id > 0)
                    {
                        this.productDataAccess.UpdateProduct(product.Id, product.BarCode, product.Name, 
                                                             product.Description, product.MeasurementUnit, product.Status);
                    }
                    else
                    {
                        this.productDataAccess.InsertProduct(product.BarCode, product.Name, product.Description,
                                                             product.MeasurementUnit, product.StockQuantity, product.Status);
                    }

                    this.productDataAccess.InsertPrice(this.productDataAccess.GetId(product.BarCode), DateTime.Now, 
                                                       product.CostPrice, product.SalePrice);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Atualiza a quantidade em estoque de um produto.
        /// </summary>
        /// <param name="product">Produto a ser atualizado</param>
        public void UpdateProductStockQuantity(Product product)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    this.productDataAccess.UpdateProductStockQuantity(product.BarCode, product.StockQuantity);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produto a ser adicionado na venda pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna o produto</returns>
        public Product GetProductSale(long barCode)
        {
            DataTable dtProduct;
            Product product = null;

            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    dtProduct = this.productDataAccess.GetProductSale(barCode);
                }

                if (dtProduct != null && dtProduct.Rows.Count == 1)
                {
                    product = new Product();
                    product.Id = (int)dtProduct.Rows[0][DatabaseConstants.ProductIdColumn];
                    product.BarCode = (long)dtProduct.Rows[0][DatabaseConstants.ProductBarCodeColumn];
                    product.Name = (string)dtProduct.Rows[0][DatabaseConstants.ProductNameColumn];
                    product.Description = (string)dtProduct.Rows[0][DatabaseConstants.ProductDescriptionColumn];
                    product.MeasurementUnit = (string)dtProduct.Rows[0][DatabaseConstants.ProductMeasurementUnitColumn];
                    product.StockQuantity = (double)dtProduct.Rows[0][DatabaseConstants.ProductStockQuantityColumn];
                    product.CostPrice = float.Parse(dtProduct.Rows[0][DatabaseConstants.PriceCostPriceColumn].ToString());
                    product.SalePrice = float.Parse(dtProduct.Rows[0][DatabaseConstants.PriceSalePriceColumn].ToString());
                }

                return product;
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produto pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductByBarCode(long barCode)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductByBarCode(barCode);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produtos pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsByName(string name)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductsByName(name);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca todos os produtos.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetAllProducts()
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetAllProducts();
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produto para venda pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductSaleByBarCode(long barCode)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductSaleByBarCode(barCode);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produtos para venda pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsSaleByName(string name)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductsSaleByName(name);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca todos os produtos para venda.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetAllProductsSale()
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetAllProductsSale();
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produto para esqtoque pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductStockByBarCode(long barCode)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductStockByBarCode(barCode);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca produtos para estoque pelo nome.
        /// </summary>
        /// <param name="name">Nome dos produtos</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsStockByName(string name)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductsStockByName(name);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca todos os produtos para estoque.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetAllProductsStock()
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetAllProductsStock();
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        /// <summary>
        /// Busca os produtos que estão em falta no estoque, de acordo com o mínimo informado.
        /// </summary>
        /// <param name="stockQuantity">Quantidade mínima de produtos no estoque</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetProductsStockMissing(double stockQuantity)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductsStockMissing(stockQuantity);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
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
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductsBestSellers(dateTimeInitial, dateTimeFinal);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
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
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    return this.productDataAccess.GetProductsWorstSellers(dateTimeInitial, dateTimeFinal);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(BusinessConstants.ProjectName,
                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                              MethodBase.GetCurrentMethod().Name,
                              ex.Message);

                throw ex;
            }
        }

        #endregion
    }
}
