using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class Table
    {
        #region -Private Attributes-

        private int number;
        private List<Product> lstProducts;

        #endregion

        #region -Constructors-

        public Table()
        {
 
        }

        public Table(int number, List<Product> lstProducts)
        {
            this.number = number;
            this.lstProducts = lstProducts;
        }

        #endregion

        #region -Public Properties-

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public List<Product> LstProducts
        {
            get { return lstProducts; }
            set { lstProducts = value; }
        }

        #endregion
    }
}
