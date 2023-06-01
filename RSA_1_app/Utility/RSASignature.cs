using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA_1_app.Utility
{
    public static class RSASignature
    {
        
        public static byte[] SignatureGenerate(string text, RSACryptoServiceProvider rsa) 
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            return rsa.SignData(textBytes, new SHA256Managed());
        }

    
    }
}
