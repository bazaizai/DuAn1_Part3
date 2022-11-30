using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Utilities
{
    internal class ValidateInput
    {
        static public bool CheckIntInput(string s)
        {
            int i;
            if (int.TryParse(s, out i))
            {
                return true;
            }
            else return false;
        }
        public static bool CheckEmpty(string Msg) => string.IsNullOrEmpty(Msg.Trim());
        public static bool InputIsOnlyNumber(string Msg) => int.TryParse(Msg.Trim(), out int x);
        // public static ValidateInput.InputIsOnlyNumber(input) ==false || (input).Substring(0, 1) != "0" || input.Length != 10 
        //demo validate check so cac thu
        static public bool CheckSDT(string s) // sdt phai nhap 10 so
        {
            if (s.Substring(0, 1) == "0" && s.Length == 10)
            {
                return true;
            }
            else return false;
        }
        public static bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            if (string.IsNullOrEmpty(phoneNum))
                return false;
            string sMailPattern = @"^((0(\d){9}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }

        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email.Trim(), @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        static public bool CheckMk(string s)
        {
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {

                if (s[i].ToString() == s[i].ToString().ToUpper() && CheckIntInput(s[i].ToString()) == false)
                {
                    a++;
                }
            }
            if (a == 1 && s.Length > 8) return true;
            else return false;
        }
        static public bool CheckDecimalInput(string s)
        {
            decimal i;
            if (decimal.TryParse(s, out i))
            {
                return true;
            }
            else return false;
        }

        public static decimal RegexDecimal(string txt)
        {
            var indecimal = txt.Replace(".", string.Empty);
            var outdecimal = indecimal.Replace("đ", string.Empty);
            return Convert.ToDecimal(outdecimal);
        }
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&()=?»«@£§€{}.;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
    }
}
