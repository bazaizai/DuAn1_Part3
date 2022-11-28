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
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
        static public bool KiemTraHoTen(string hoTen)
        {
            // Kiem tra giua 2 chu chi co 1 khoang trang
            if (hoTen.IndexOf(" ") == -1) return false;
            // Kiem tra cac ky tu dau phai viet hoa
            string[] arr = hoTen.Split(' ');
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (char.IsLower(arr[i][0]) == true) return false;
            //}
            return true;
        }    

        public static bool CheckEmpty(string Msg) => string.IsNullOrEmpty(Msg.Trim());
        public static bool InputIsOnlyNumber(string Msg) => int.TryParse(Msg.Trim(), out int x);

        public static bool IsValidVietNamPhoneNumber(string phoneNum)
        {
            if (string.IsNullOrEmpty(phoneNum))
                return false;
            string sMailPattern = @"^((0(\d){9}))$";
            return Regex.IsMatch(phoneNum.Trim(), sMailPattern);
        }
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }
        static public bool KiemTraHoTen(string hoTen)
        {
            // Kiem tra giua 2 chu chi co 1 khoang trang
            //if (hoTen.IndexOf(" ") == -1) return false;
            // Kiem tra cac ky tu dau phai viet hoa
            string[] arr = hoTen.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i][0]) == true) return false;
            }
            return true;
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
