using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Clinic_Project
{
    public class Class1
    {
        private TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider();
        public Class1(string key)
        {
            des.Key = Encoding.UTF8.GetBytes(key);
            des.Mode = CipherMode.ECB;

        }
        public void encrypt(string filepath)
        {
            byte[] Bytes = File.ReadAllBytes(filepath);
            byte[] ebytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0,Bytes.Length);
            File.WriteAllBytes(filepath, ebytes);
        }
        public void decrypt(string filepath)
        {
            byte[] bytes = File.ReadAllBytes(filepath);
            byte[] dbytes = des.CreateDecryptor().TransformFinalBlock(bytes, 0, bytes.Length);
            File.WriteAllBytes(filepath, dbytes);
        }
    }
}
