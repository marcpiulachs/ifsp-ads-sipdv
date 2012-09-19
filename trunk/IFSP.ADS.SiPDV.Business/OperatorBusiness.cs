using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

using IFSP.ADS.SiPDV.Database;
using IFSP.ADS.SiPDV.Framework;
using IFSP.ADS.SiPDV.Log;
using IFSP.ADS.SiPDV.Tools.Cryptography;

namespace IFSP.ADS.SiPDV.Business
{
    public class OperatorBusiness
    {
        #region -Private Attributes-

        private OperatorDataAccess operatorDataAccess;

        #endregion

        #region -Public Methods-

        public int Login(Operator oper)
        {
            try
            {
                oper.Password = PasswordTools.GenerateEncodedPassword(oper.Password);

                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    return this.operatorDataAccess.Login(oper.Code, oper.Password);
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

        public void InsertUpdateOperator(Operator oper)
        {
            try
            {
                // Gera o hash da senha.
                oper.Password = PasswordTools.GenerateEncodedPassword(oper.Password);

                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    if (oper.Id > 0)
                    {
                        this.operatorDataAccess.UpdateOperator(oper.Id, oper.Code, oper.Name, oper.Password);
                    }
                    else
                    {
                        this.operatorDataAccess.InsertOperator(oper.Code, oper.Name, oper.Password, oper.Status);
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

        public void DeleteOperator(Operator oper)
        {
            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    this.operatorDataAccess.UpdateOperatorStatus(oper.Code, oper.Status);
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

        public DataTable GetAllOperators()
        {
            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    return this.operatorDataAccess.GetAllOperators();
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

        public DataTable GetOperatorsByCode(string code)
        {
            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    return this.operatorDataAccess.GetOperatorsByCode(code);
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

        public DataTable GetOperatorsByName(string name)
        {
            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    return this.operatorDataAccess.GetOperatorsByName(name);
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
