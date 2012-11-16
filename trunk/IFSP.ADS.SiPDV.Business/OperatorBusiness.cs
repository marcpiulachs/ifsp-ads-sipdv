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

        /// <summary>
        /// Valida o login do operador.
        /// </summary>
        /// <param name="oper">Operador que deseja fazer o login</param>
        /// <returns>Retorna o id do operador em caso de sucesso, ou 0 caso o login não seja válido</returns>
        public int Login(Operator oper)
        {
            try
            {
                // Gera o hash da senha.
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

        /// <summary>
        /// Insere um novo operador ou atualiza caso ele já exista.
        /// </summary>
        /// <param name="oper">Operador a ser inserido ou atualizado</param>
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

        /// <summary>
        /// Remove um operador.
        /// </summary>
        /// <param name="oper">Operador a ser removido</param>
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

        /// <summary>
        /// Busca operador pelo id.
        /// </summary>
        /// <param name="id">Id do operador</param>
        /// <returns>Retorna o operador</returns>
        public Operator OperatorById(int id)
        {
            Operator oper = null;
            DataTable dtOperator;

            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    dtOperator = this.operatorDataAccess.GetOperatorById(id);
                }

                if (dtOperator != null && dtOperator.Rows.Count > 0)
                {
                    oper = new Operator();
                    oper.Id = (int)dtOperator.Rows[0][DatabaseConstants.OperatorIdColumn];
                    oper.Code = (string)dtOperator.Rows[0][DatabaseConstants.OperatorCodeColumn];
                    oper.Name = (string)dtOperator.Rows[0][DatabaseConstants.OperatorNameColumn];
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

            return oper;
        }

        /// <summary>
        /// Busca operador pelo id.
        /// </summary>
        /// <param name="id">Id do operador</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetOperatorById(int id)
        {
            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    return this.operatorDataAccess.GetOperatorById(id);
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

        /// <summary>
        /// Busca operador pelo código.
        /// </summary>
        /// <param name="code">Código do operador</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
        public DataTable GetOperatorByCode(string code)
        {
            try
            {
                using (this.operatorDataAccess = new OperatorDataAccess())
                {
                    return this.operatorDataAccess.GetOperatorByCode(code);
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

        /// <summary>
        /// Busca operadores pelo nome.
        /// </summary>
        /// <param name="name">Nome dos operadores</param>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
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

        /// <summary>
        /// Busca todos os operadores.
        /// </summary>
        /// <returns>Retorna um DataTable contendo a busca realizada</returns>
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

        #endregion
    }
}
