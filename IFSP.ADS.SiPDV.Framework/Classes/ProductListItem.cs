using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class ProductListItem
    {
        #region -Private Attributes-

        private int id;
        private long barCode;
        private string name;
        private int quantity;
        private float price;
        private float subtotal;

        #endregion

        #region -Constructors-

        public ProductListItem()
        {

        }

        public ProductListItem(Product product, int quantity)
        {
            this.id = product.Id;
            this.barCode = product.BarCode;
            this.name = product.Name;
            this.quantity = quantity;
            this.price = product.SalePrice;
            this.subtotal = this.quantity * this.price;
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

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        #endregion

        #region -Public Methods-

        public void CalculateSubtotal()
        {
            this.subtotal = this.quantity * this.price;
        }

        public override string ToString()
        {
            return string.Format("{0,-13} {1,-20} {2,3} {3,7:0.00} {4,7:0.00}", this.barCode, this.name, this.quantity, this.price, this.subtotal);
        }

        #endregion
    }
}
