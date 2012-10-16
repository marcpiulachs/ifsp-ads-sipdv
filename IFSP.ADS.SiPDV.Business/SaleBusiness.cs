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
    public class SaleBusiness
    {
        #region -Private Attributes-

        private SaleDataAccess saleDataAccess;

        #endregion

        #region -Public Methods-

        /// <summary>
        /// Insere uma nova venda.
        /// </summary>
        /// <param name="sale">Venda realizada</param>
        /// <param name="lstProducts">Lista de produtos vendidos</param>
        public void InsertSale(Sale sale, List<Product> lstProducts)
        {
            try
            {
                using (this.saleDataAccess = new SaleDataAccess())
                {
                    this.saleDataAccess.InsertSale(sale.OperatorId, sale.DateTime, sale.Subtotal, sale.Discount, sale.Total);

                    sale.Id = this.saleDataAccess.GetId(sale.OperatorId, sale.DateTime);

                    if (sale.Id > 0)
                    {
                        foreach (Product product in lstProducts)
                        {
                            try
                            {
                                this.saleDataAccess.InsertSaleProducts(sale.Id, product.Id, product.Quantity, product.CostPrice, product.SalePrice);
                            }
                            catch (Exception ex)
                            {
                                Logging.Error(BusinessConstants.ProjectName,
                                              MethodBase.GetCurrentMethod().DeclaringType.Name,
                                              MethodBase.GetCurrentMethod().Name,
                                              ex.Message);
                            }
                        }
                    }
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
