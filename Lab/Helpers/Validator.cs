using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    static class SValidator
    {
        // login can contain only letters, digits and underscores
        public static Boolean IsValidLogin(string login)
        {
            if (String.IsNullOrEmpty(login))
                return false;
            if (login.Length > 32)
                return false;
            return login.All(x => Char.IsLetterOrDigit(x) || x == '_');
        }

        // Password must be at least 8 characters
        // -------- must contain at least one uppercase letter, lowercase letter and digit
        public static Boolean IsValidPassword(SecureString password)
        {
            if (password == null)
                return false;
            if (password.Length < 8)
                return false;
            Boolean hasLowercaseLetter = false;
            Boolean hasUppercaseLetter = false;
            Boolean hasDigit = false;
            Char[] chars = new char[password.Length];
            IntPtr ptr = IntPtr.Zero;
            try
            {
                ptr = Marshal.SecureStringToGlobalAllocUnicode(password);
                Marshal.Copy(ptr, chars, 0, password.Length);
                hasLowercaseLetter = chars.Any(Char.IsLower);
                hasUppercaseLetter = chars.Any(Char.IsUpper);
                hasDigit = chars.Any(Char.IsDigit);
            }
            finally
            {
                Array.Clear(chars, 0, chars.Length);
                Marshal.ZeroFreeGlobalAllocUnicode(ptr);
            }

            return hasLowercaseLetter && hasUppercaseLetter && hasDigit;
        }

        public static bool HasCredentials(string login, SecureString password)
        {
            if (String.IsNullOrEmpty(login))
                return false;
            if (password == null || password.Length == 0)
                return false;
            return true;
        }

    }
}
