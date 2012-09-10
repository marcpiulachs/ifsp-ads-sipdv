using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace IFSP.ADS.SiPDV.Tools.Cryptography
{
    public class PasswordTools
    {
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
    }
}
