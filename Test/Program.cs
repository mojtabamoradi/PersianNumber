using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Hello, Welcome to .Net Language Persian Numbers Converter Library [Moraba.Persian.Numbers.Core]");
            Console.WriteLine("The package can be easily installed via Nuget.");
            Console.WriteLine("Package Manager");
            Console.WriteLine("PM> Install-Package Moraba.Persian.Numbers.Core");
            Console.WriteLine();
            Console.WriteLine("please enter number : ");
            var input = Console.ReadLine();
            var output = Moraba.Persian.Numbers.Convert.NumberToText(input);
            Console.WriteLine("result : {0}", output);
            Console.WriteLine();
            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();
        }
    }
}
