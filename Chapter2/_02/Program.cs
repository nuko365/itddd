using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "naruse masanobu";
            var tokens = fullName.Split(' ');
            var lastNme = tokens[0];
            Console.WriteLine(lastNme);
        }
    }
}
