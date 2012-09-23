using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class Sale
    {
        #region -Private Attributes-

        private int id;
        private int operatorId;
        private DateTime dateTime;
        private float subtotal;
        private float discount;
        private float total;

        #endregion

        #region -Constructors-

        public Sale()
        {

        }

        public Sale(int id, int operatorId, DateTime dateTime, float subtotal, float discount, float total)
        {
            this.id = id;
            this.operatorId = operatorId;
            this.dateTime = dateTime;
            this.subtotal = subtotal;
            this.discount = discount;
            this.total = total;
        }

        #endregion

        #region -Public Properties-

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int OperatorId
        {
            get { return operatorId; }
            set { operatorId = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public float Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        #endregion
    }
}
