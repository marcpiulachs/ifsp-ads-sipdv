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

        /// <summary>
        /// Construtor privado padrão.
        /// </summary>
        private SharedData()
        {

        }

        #endregion

        #region -Singleton-

        /// <summary>
        /// Retorna a instância da SharedMemory. Caso ela seja nula, cria uma instância.
        /// </summary>
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

        /// <summary>
        /// Limpa a SharedMemory.
        /// </summary>
        public void Clear()
        {
            this.operatorData = null;
        }

        #endregion
    }
}
