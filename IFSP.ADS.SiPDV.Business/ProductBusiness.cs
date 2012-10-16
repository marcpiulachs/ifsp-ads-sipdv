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
                                                             product.Description, product.MeasurementUnit);
                    }
                    else
                    {
                        this.productDataAccess.InsertProduct(product.BarCode, product.Name, product.Description,
                                                             product.MeasurementUnit, product.Quantity, product.Status);
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
        /// Remove um produto.
        /// </summary>
        /// <param name="product">Produto a ser removido</param>
        public void DeleteProduct(Product product)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    this.productDataAccess.UpdateProductStatus(product.BarCode, 0);
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
        public void UpdateProductQuantity(Product product)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    this.productDataAccess.UpdateProductQuantity(product.BarCode, product.Quantity);
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
        /// Busca produto pelo código de barras.
        /// </summary>
        /// <param name="barCode">Código de barras do produto</param>
        /// <returns>Retorna o produto</returns>
        public Product ProductByBarCode(long barCode)
        {
            DataTable dtProduct;
            Product product = null;

            try
            {
                dtProduct = GetProductByBarCode(barCode);

                if (dtProduct != null && dtProduct.Rows.Count == 1)
                {
                    product = new Product();
                    product.Id = (int)dtProduct.Rows[0][DatabaseConstants.ProductIdColumn];
                    product.BarCode = (long)dtProduct.Rows[0][DatabaseConstants.ProductBarCodeColumn];
                    product.Name = (string)dtProduct.Rows[0][DatabaseConstants.ProductNameColumn];
                    product.Description = (string)dtProduct.Rows[0][DatabaseConstants.ProductDescriptionColumn];
                    product.MeasurementUnit = (string)dtProduct.Rows[0][DatabaseConstants.ProductMeasurementUnitColumn];
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
                    return this.productDataAccess.GetProductsByBarCode(barCode);
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
                    return this.productDataAccess.GetProductsStockByBarCode(barCode);
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

        #endregion
    }
}
