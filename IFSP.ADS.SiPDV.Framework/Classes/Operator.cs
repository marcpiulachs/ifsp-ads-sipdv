using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IFSP.ADS.SiPDV.Framework
{
    public class Operator
    {
        #region -Private Attributes-

        private int id;
        private string code;
        private string name;
        private string password;
        private int status;

        #endregion

        #region -Constructors-

        public Operator()
        {
 
        }

        public Operator(int id, string code, string name, string password, int status)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.password = password;
            this.status = status;
        }

        #endregion

        #region -Public Properties-

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        #endregion
    }
}
