using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace GMR.Infrastructure
{
    public class Сryptographer : IСryptographer
    {
        private const string EncryptionKey = "MAKV2SPBNI99212";

        private const int SecurityKetSize = 32;

        private const int InitializationVectorSize = 16;

        private readonly byte[] Salt = new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 };

        public string Encrypt(string text)
        {
            
            byte[] clearBytes = Encoding.Unicode.GetBytes(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, Salt);
                encryptor.Key = pdb.GetBytes(SecurityKetSize);
                encryptor.IV = pdb.GetBytes(InitializationVectorSize);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }

                    text = Convert.ToBase64String(ms.ToArray());
                }
            }

            return text;
        }

        public string Decrypt(string text)
        {
            byte[] cipherBytes = Convert.FromBase64String(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, Salt);
                encryptor.Key = pdb.GetBytes(SecurityKetSize);
                encryptor.IV = pdb.GetBytes(InitializationVectorSize);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }

                    text = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return text;
        }
    }
}
