using System;
using System.Collections.Generic;
using System.Text;

namespace Moraba.Persian.Numbers
{
    public class Convert
    {
        public static string EnglishToPersian(string input)
        {
            return ConvertService.EnglishToPersian(input);
        }

        public static string EnglishToPersian(int input)
        {
            return EnglishToPersian(input.ToString());
        }

        public static string EnglishToPersian(long input)
        {
            return EnglishToPersian(input.ToString());
        }

        public static string EnglishToPersian(float input)
        {
            return EnglishToPersian(input.ToString());
        }

        public static string EnglishToPersian(double input)
        {
            return EnglishToPersian(input.ToString());
        }

        public static string EnglishToPersian(decimal input)
        {
            return EnglishToPersian(input.ToString());
        }

        public static string PersianToEnglish(string input)
        {
            return ConvertService.PersianToEnglish(input);
        }

        public static int PersianToEnglishInt32(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            input = input.NormalizeNumber();
            if (!input.IsInteger()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            return ConvertService.PersianToEnglishInt32(input);

        }

        public static long PersianToEnglishInt64(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            input = input.NormalizeNumber();
            if (!input.IsInteger()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            return ConvertService.PersianToEnglishInt64(input);
        }

        public static float PersianToEnglishFloat(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            input = input.NormalizeNumber();
            return ConvertService.PersianToEnglishFloat(input);
        }

        public static double PersianToEnglishDouble(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            input = input.NormalizeNumber();
            return ConvertService.PersianToEnglishDouble(input);
        }

        public static Decimal PersianToEnglishDecimal(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            input = input.NormalizeNumber();
            return ConvertService.PersianToEnglishDecimal(input);
        }

        public static string PersianToBase64(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            return ConvertService.PersianToBase64(input);
        }

        public static string Base64ToPersian(string base64)
        {
            return ConvertService.Base64ToPersian(base64);
        }

        public static string EnglishToBase64(string input)
        {
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            return ConvertService.EnglishToBase64(input);
        }

        public static string Base64ToEnglish(string base64)
        {
            return ConvertService.Base64ToEnglish(base64);
        }
        public static string NumberToText(string input)
        {
            input = PersianToEnglish(input);
            if (!input.IsNumber()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            input = input.NormalizeNumber();
            if (!input.IsInteger()) { throw new FormatException(Messages.InvalidNumberFormatException); }
            return ConvertService.NumberToText(input);
        }
    }
}
