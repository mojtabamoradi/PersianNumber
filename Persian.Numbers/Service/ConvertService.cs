using System;
using System.Collections.Generic;
using System.Text;

namespace Moraba.Persian.Numbers
{
    class ConvertService
    {
        public static string EnglishToPersian(string input)
        {
            return input.ConvertEnglishNumberToPersianNumber();
        }

        public static string PersianToEnglish(string input)
        {
            return input.ConvertPersianNumberToEnglishNumber();
        }

        public static int PersianToEnglishInt32(string input)
        {
            return System.Convert.ToInt32(input.ConvertPersianNumberToEnglishNumber());
        }

        public static long PersianToEnglishInt64(string input)
        {
            return System.Convert.ToInt64(input.ConvertPersianNumberToEnglishNumber());
        }

        public static float PersianToEnglishFloat(string input)
        {
            return System.Convert.ToSingle(input.ConvertPersianNumberToEnglishNumber());
        }

        public static double PersianToEnglishDouble(string input)
        {
            return System.Convert.ToDouble(input.ConvertPersianNumberToEnglishNumber());
        }

        public static Decimal PersianToEnglishDecimal(string input)
        {
            return System.Convert.ToDecimal(input.ConvertPersianNumberToEnglishNumber());
        }

        public static string PersianToBase64(string input)
        {
            return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(input.ConvertPersianNumberToEnglishNumber()));
        }

        public static string Base64ToPersian(string base64)
        {
            return Encoding.UTF8.GetString(System.Convert.FromBase64String(base64)).ConvertEnglishNumberToPersianNumber();
        }

        public static string EnglishToBase64(string input)
        {
            return System.Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
        }

        public static string Base64ToEnglish(string base64)
        {
            return Encoding.UTF8.GetString(System.Convert.FromBase64String(base64)).ConvertPersianNumberToEnglishNumber();
        }


        public static string NumberToText(string input)
        {
            return PersianText.PersianNumberToString(input);
        }
    }
}
