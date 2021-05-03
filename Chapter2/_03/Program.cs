using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "john smith";
            var tokens = fullName.Split(' ');
            var lastNme = tokens[0];
            Console.WriteLine(lastNme);
        }
    }
}
