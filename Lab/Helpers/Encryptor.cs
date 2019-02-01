using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal static class SEncryptor
    {
        public static string GetSHA256Hash(SecureString plainSecureString)
        {
            Byte[] buffer = new Byte[plainSecureString.Length*2];
            IntPtr ptr = IntPtr.Zero;
            String result;
            try
            {
                ptr = Marshal.SecureStringToGlobalAllocUnicode(plainSecureString);
                Marshal.Copy(ptr, buffer, 0, buffer.Length);
                using (var sha256 = SHA256.Create())
                {
                    var hash = sha256.ComputeHash(buffer);
                    result = GetStringFromByteArray(hash);
                }
            }
            finally
            {
                Array.Clear(buffer, 0, buffer.Length);
                Marshal.ZeroFreeGlobalAllocUnicode(ptr);
            }

            return result;
        }

        private static string GetStringFromByteArray(Byte[] array)
        {
            var sBuilder = new StringBuilder();
            foreach (var b in array)
            {
                sBuilder.Append(b.ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
