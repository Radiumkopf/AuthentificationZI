using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AuthentificationZI
{
    internal class Des
    {
        //Функиции шифрования и дешифрования
        public static string Encrypt(string originalString, byte[] key)
        {
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoServiceProvider.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

            using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
            {
                streamWriter.Write(originalString);
                streamWriter.Flush();
                cryptoStream.FlushFinalBlock();


                return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
            }
        }

        public static string Decrypt(string cryptedString, byte[] key)
        {
            DESCryptoServiceProvider cryptoServiceProvider = new DESCryptoServiceProvider();
            MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                cryptoServiceProvider.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

            using (StreamReader streamReader = new StreamReader(cryptoStream))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
