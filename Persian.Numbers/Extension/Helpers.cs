using Moraba.Persian.Numbers.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moraba.Persian.Numbers
{
    static class Helpers
    {
        public static string ConvertPersianNumberToEnglishNumber(this string numbers)
        {
            if (string.IsNullOrEmpty(numbers) || string.IsNullOrWhiteSpace(numbers)) { return numbers; }
            numbers = numbers.Replace(PersianNumbers.Zero, EnglishNumbers.Zero);
            numbers = numbers.Replace(PersianNumbers.One, EnglishNumbers.One);
            numbers = numbers.Replace(PersianNumbers.Two, EnglishNumbers.Two);
            numbers = numbers.Replace(PersianNumbers.Three, EnglishNumbers.Three);
            numbers = numbers.Replace(PersianNumbers.Four, EnglishNumbers.Four);
            numbers = numbers.Replace(PersianNumbers.Five, EnglishNumbers.Five);
            numbers = numbers.Replace(PersianNumbers.Six, EnglishNumbers.Six);
            numbers = numbers.Replace(PersianNumbers.Seven, EnglishNumbers.Seven);
            numbers = numbers.Replace(PersianNumbers.Eight, EnglishNumbers.Eight);
            numbers = numbers.Replace(PersianNumbers.Nine, EnglishNumbers.Nine);
            return numbers;
        }

        public static string ConvertEnglishNumberToPersianNumber(this string numbers)
        {
            if (string.IsNullOrEmpty(numbers) || string.IsNullOrWhiteSpace(numbers)) { return numbers; }
            numbers = numbers.Replace(EnglishNumbers.Zero, PersianNumbers.Zero);
            numbers = numbers.Replace(EnglishNumbers.One, PersianNumbers.One);
            numbers = numbers.Replace(EnglishNumbers.Two, PersianNumbers.Two);
            numbers = numbers.Replace(EnglishNumbers.Three, PersianNumbers.Three);
            numbers = numbers.Replace(EnglishNumbers.Four, PersianNumbers.Four);
            numbers = numbers.Replace(EnglishNumbers.Five, PersianNumbers.Five);
            numbers = numbers.Replace(EnglishNumbers.Six, PersianNumbers.Six);
            numbers = numbers.Replace(EnglishNumbers.Seven, PersianNumbers.Seven);
            numbers = numbers.Replace(EnglishNumbers.Eight, PersianNumbers.Eight);
            numbers = numbers.Replace(EnglishNumbers.Nine, PersianNumbers.Nine);
            return numbers;
        }

        public static string NormalizeNumber(this string number)
        {
            if (String.IsNullOrEmpty(number) || String.IsNullOrWhiteSpace(number))
                return number;
            if (number.StartsWith("."))
                number = string.Format("{0}" + number, "0");
            if (number.EndsWith("."))
                number = string.Format(number + "{0}", "0");
            return number;
        }

        public static bool IsNumber(this string input)
        {
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input)) { return false; }
            input = input.Trim();
            if (input.Where(c => !char.IsDigit(c) && c != '.' && c != '-').Count() > 0) { return false; }
            if (input.Where(c => c == '.').Count() > 1) { return false; }
            if (input.Where(c => c == '-').Count() > 1) { return false; }
            if (input.Contains('-') && !input.StartsWith('-')) { return false; }
            return true;
        }

        public static bool IsInteger(this string input)
        {
            if (!IsNumber(input)) { return false; }
            if (input.Where(c => c == '.').Count() > 0) { return false; }
            return true;
        }
    }
}
