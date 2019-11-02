using System;

namespace FooBarQix
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Number :");
            string input = Console.ReadLine();
            Console.WriteLine("Ouput:"+GetFooBarQix(input.Trim()));
            Console.ReadLine();
        }

        public static string GetFooBarQix(string input)
        {
            var isValid = int.TryParse(input, out int inputnumber);
            if (isValid)
            {
                var divisiblestring = Helper.IsDivisble(inputnumber); 
                var Digitstring=Helper.ContainsDigits(inputnumber);
                
                if(string.IsNullOrEmpty(divisiblestring) && string.IsNullOrEmpty(Digitstring))
                {
                    return input;
                }
                return divisiblestring + Digitstring;
            }
            return string.Empty;
        }

    }
}
   