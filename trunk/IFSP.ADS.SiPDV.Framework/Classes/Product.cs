using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class Product
    {
        #region -Private Attributes-

        private int id;
        private long barCode;
        private string name;
        private string description;
        private string measurementUnit;
        private int quantity;
        private float costPrice;
        private float salePrice;

        #endregion

        #region -Constructors-

        public Product()
        {

        }

        public Product(int id, long barCode, string name, string description, 
                       string measurementUnit, int quantity, float costPrice, float salePrice)
        {
            this.id = id;
            this.barCode = barCode;
            this.name = name;
            this.description = description;
            this.measurementUnit = measurementUnit;
            this.quantity = quantity;
            this.costPrice = costPrice;
            this.salePrice = salePrice;
        }

        #endregion

        #region -Public Properties-

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public long BarCode
        {
            get { return barCode; }
            set { barCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string MeasurementUnit
        {
            get { return measurementUnit; }
            set { measurementUnit = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float CostPrice
        {
            get { return costPrice; }
            set { costPrice = value; }
        }

        public float SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }

        #endregion
    }
}
