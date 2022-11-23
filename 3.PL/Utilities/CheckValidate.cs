using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.PL.Utilities
{
    public class CheckValidate
    {
        public static bool CheckEmpty(string Msg) => string.IsNullOrEmpty(Msg.Trim());
        public static bool InputIsOnlyNumber(string Msg) => int.TryParse(Msg.Trim(), out int x);

        public static bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            if (string.IsNullOrEmpty(phoneNum))
                return false;
            string sMailPattern = @"^((0(\d){9}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }
         public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

    }
}
