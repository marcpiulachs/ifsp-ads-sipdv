using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using IFSP.ADS.SiPDV.Framework;

namespace IFSP.ADS.SiPDV.SharedMemory
{
    public class SharedData
    {
        #region -Private Attributes-

        private static SharedData instance;

        private Operator operatorData;

        #endregion

        #region -Constructor-

        private SharedData()
        {

        }

        #endregion

        #region -Singleton-

        public static SharedData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SharedData();
                }

                return instance;
            }
        }

        #endregion

        #region -Public Properties-

        public Operator OperatorData
        {
            get { return operatorData; }
            set { operatorData = value; }
        }

        #endregion

        #region -Public Methods-

        public void Clear()
        {
            this.operatorData = null;
        }

        #endregion
    }
}
