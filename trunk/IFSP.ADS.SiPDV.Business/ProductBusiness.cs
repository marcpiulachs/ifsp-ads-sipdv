using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using IFSP.ADS.SiPDV.Database;
using IFSP.ADS.SiPDV.Framework;

namespace IFSP.ADS.SiPDV.Business
{
    public class ProductBusiness
    {
        #region -Private Attributes-

        private ProductDataAccess productDataAccess;

        #endregion

        #region -Public Methods-

        public void InsertProduct(Product product)
        {
            try
            {
                using (this.productDataAccess = new ProductDataAccess())
                {
                    this.productDataAccess.InsertProduct(product.BarCode, product.Name, product.Description, 
                                                         product.MeasurementUnit, product.Quantity, DateTime.Now, 
                                                         product.CostPrice, product.SalePrice);

                    int productId = this.productDataAccess.GetId(product.BarCode);
                }
            }
            catch (Exception ex)
            {
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
                throw ex;
            }
        }

        public Product GetProductByBarCode(long barCode)
        {
            try
            {
                DataTable dt = GetProductsByBarCode(barCode);

                if (dt != null && dt.Rows.Count == 1)
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return null;
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
                throw ex;
            }
        }

        #endregion
    }
}
