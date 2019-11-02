using System;
using System.Collections.Generic;
using System.Text;

namespace FooBarQix
{
    public static class Helper
    {
        public static string IsDivisble(int number)
        {
            StringBuilder output = new StringBuilder();
            if (number % 3 == 0)
                output.Append("Foo");
            if (number % 5 == 0)
                output.Append("Bar");
            if (number % 7 == 0)
                output.Append("Qix");
            return output?.ToString();
        }

        public static string ContainsDigits(int number)
        {
            StringBuilder output = new StringBuilder();
            char[] charArr = number.ToString().ToCharArray();
            foreach (char ch in charArr)
            {
                if (ch == '0')
                    output.Append("*");
                if (ch == '3')
                    output.Append("Foo");
                if (ch == '5')
                    output.Append("Bar");
                if (ch == '7')
                    output.Append("Qix");
            }
            return output?.ToString();
        }
    }
}
 