using System;
using System.Collections.Generic;
using System.Text;

namespace Number.Converter
{
    public static class NumberExtension
    {
        private static String convertLessThanOneThousand(int number)
        {
            String current;

            if (number % 100 < 20)
            {
                current = Constants.smallNumberStrings[number % 100];
                number /= 100;
            }
            else
            {
                current = Constants.smallNumberStrings[number % 10];
                number /= 10;

                current =  Constants.tenthNumberStrings[number % 10] + current;
                number /= 10;
            }
            if (number == 0) return current;
            return Constants.smallNumberStrings[number] + " Hundred" + current;
        }

        public static String ConvertToSpelling(this int number)
        {

            if (number == 0) { return "zero"; }

            String prefix = "";

   

            String current = "";
            int place = 0;

            do
            {
                int n = number % 1000;
                if (n != 0)
                {
                    String s = convertLessThanOneThousand(n);
                    current = s + Constants.bignumberStrings[place] + current;
                }
                place++;
                number /= 1000;
            } while (number > 0);

            return (prefix + current).Trim();
        }
    }
}
