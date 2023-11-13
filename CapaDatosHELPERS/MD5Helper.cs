using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PSMIN.HELPERS
{
    public static class MD5Helper
    {
        /// <summary>
        /// Genera Hash MD5 de la cadena que se ingresa
        /// </summary>
        /// <param name="word">palabra a ser procesada</param>
        /// <returns>Hash MD5 del la palabra ingresada</returns>
        public static string HashMD5(string word)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(word));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
