using System;
using System.Collections.Generic;
using System.Text;

namespace Moraba.Persian.Numbers
{
    class PersianText
    {
        static readonly string[] persianText_0_9 = new string[] { "صفر", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
        static readonly string[] persianText_10_19 = new string[] { "ده", "یازده", "دوازده", "سیزده", "چهارده", "پانزده", "شانزده", "هفده", "هجده", "نوزده" };
        static readonly string[] persianText_20_90 = new string[] { "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
        static readonly string[] persianText_100_900 = new string[] { "صد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };
        static readonly string[] persianText_1000_ = new string[] { "هزار", "میلیون", "میلیارد", "تريليون" };
        static readonly string persianText_Splitter = " و ";
        static readonly string persianText_VeryBig = "تعریف نشده";
        static readonly string persianText_Negative = "منفی";

        static string GetPart(string number)
        {
            if (number.Length > 3) { return ""; }
            switch (number.Length)
            {
                case 1:
                    number = "00" + number;
                    break;
                case 2:
                    number = "0" + number;
                    break;
            }
            var outString = "";
            var n1 = System.Convert.ToInt32(number.Substring(0, 1));
            var n2 = System.Convert.ToInt32(number.Substring(1, 1));
            var n3 = System.Convert.ToInt32(number.Substring(2, 1));
            if (n1 != 0)
            {
                switch (n2)
                {
                    case 0:
                        if (n3 != 0)
                        {
                            outString = persianText_100_900[n1 - 1] + persianText_Splitter + persianText_0_9[n3];
                        }
                        else
                        {
                            outString = persianText_100_900[n1 - 1];
                        };
                        break;
                    case 1:
                        outString = persianText_100_900[n1 - 1] + persianText_Splitter + persianText_10_19[n3];
                        break;
                    default:
                        if (n3 != 0)
                        {
                            outString = persianText_100_900[n1 - 1] + persianText_Splitter + persianText_20_90[n2 - 2] + persianText_Splitter + persianText_0_9[n3];
                        }
                        else
                        {
                            outString = persianText_100_900[n1 - 1] + persianText_Splitter + persianText_20_90[n2 - 2];
                        }
                        break;
                }
            }
            else
            {
                switch (n2)
                {
                    case 0:
                        if (n3 != 0)
                        {
                            outString = persianText_0_9[n3];
                        }
                        else
                        {
                            outString = "";
                        }
                        break;
                    case 1:
                        outString = persianText_10_19[n3];
                        break;
                    default:
                        if (n3 != 0)
                        {
                            outString = persianText_20_90[n2 - 2] + persianText_Splitter + persianText_0_9[n3];
                        }
                        else
                        {
                            outString = persianText_20_90[n2 - 2];
                        }
                        break;
                }
            };

            return outString;
        }
       public static string PersianNumberToString(string inputNumber)
        {
            var tempNumber = inputNumber.TrimStart('-');
            if (tempNumber.Length > 15) { return persianText_VeryBig; }
            if (!Helpers.IsInteger(inputNumber))
            {
                tempNumber = "";
            }

            if (tempNumber.Length == 0)
            {
                return "";
            }

            if (System.Convert.ToInt64(tempNumber) == 0)
                return persianText_0_9[0];

            var tagh = tempNumber.Length / 3;
            var bagh = tempNumber.Length % 3;
            var partCount = Math.Ceiling(System.Convert.ToDecimal(tagh)) + (bagh > 0 ? 1 : 0);

            var partFullString = new string[15];
            var numberLength3 = 0;
            var lengthToSelectFirtPart = 0;
            for (var i = 0; i < partCount; i++)
            {
                if (i == 0)
                {
                    lengthToSelectFirtPart = System.Convert.ToInt32(tempNumber.Length - ((partCount - 1) * 3));
                    numberLength3 = System.Convert.ToInt32(tempNumber.Substring((i * 3), lengthToSelectFirtPart));
                }
                else
                {
                    numberLength3 = System.Convert.ToInt32(tempNumber.Substring(lengthToSelectFirtPart + ((i - 1) * 3), 3));
                }

                var partInWord = GetPart(numberLength3.ToString());

                var partIndex = System.Convert.ToInt32(partCount - 2 - i);
                var partPreFix = String.Empty;
                if (partIndex >= 0)
                    partPreFix = persianText_1000_[partIndex];

                if (i == partCount - 1)
                {
                    partPreFix = "";
                }

                if (i == 0)
                {
                    if (partInWord != "")
                    {
                        partFullString[i] = partInWord + " " + partPreFix;
                    }
                    else
                    {
                        partFullString[i] = "";
                    }
                }
                else
                {
                    if (partFullString[i - 1] != "")
                    {
                        if (partInWord != "")
                        {
                            partFullString[i] = persianText_Splitter + partInWord + " " + partPreFix;
                        }
                        else
                        {
                            partFullString[i] = "";
                        }
                    }
                    else
                    {
                        if (partInWord != "")
                        {
                            partFullString[i] = persianText_Splitter + partInWord + " " + partPreFix;
                        }
                        else
                        {
                            partFullString[i] = "";
                        }
                    }
                }
            }

            var outString = "";

            for (var i = 0; i < partFullString.Length; i++)
            {
                outString += partFullString[i];
            }

            if (inputNumber.ToString().Substring(0, 1) == "-")
            {
                outString = persianText_Negative + " " + outString;
            }

            return outString;


        }
    }
}
