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

        public Product GetProductByBarCode(long barCode)
        {
            DataTable dtProduct;
            Product product = null;

            try
            {
                dtProduct = GetProductsByBarCode(barCode);

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

        public DataTable GetProductsByBarCode(long barCode)
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

        #endregion
    }
}
