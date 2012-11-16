using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace IFSP.ADS.SiPDV.Tools.Cryptography
{
    public class PasswordTools
    {
        #region -Public Static Methods-

        /// <summary>
        /// Gera um código hash com o algoritmo MD5 da senha do operador.
        /// </summary>
        /// <param name="password">Senha do operador</param>
        /// <returns>Código hash da senha do operador</returns>
        public static string GenerateEncodedPassword(string password)
        {
            MD5 md5;
            byte[] encodedBytes;

            try
            {
                md5 = MD5.Create();

                encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));

                return BitConverter.ToString(encodedBytes).Replace("-", "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
