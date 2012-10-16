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
        private List<Table> tablesData;

        #endregion

        #region -Constructor-

        private SharedData()
        {
            InitializeTables();
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

        public List<Table> TablesData
        {
            get { return tablesData; }
            set { tablesData = value; }
        }

        #endregion

        #region -Public Methods-

        public void InitializeTables()
        {
            Table table;
            this.tablesData = new List<Table>();

            for (int i = 0; i < 25; i++)
            {
                table = new Table(i + 1, new List<Product>());
                this.tablesData.Add(table);
            }
        }

        public void Clear()
        {
            this.operatorData = null;
            this.tablesData = null;
        }

        #endregion
    }
}
