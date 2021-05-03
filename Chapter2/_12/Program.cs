using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = new FullName("masanobu", "naruse");
            Console.WriteLine(fullName);
            fullName = new FullName("masanobu", "sato");
            Console.WriteLine(fullName);
        }
    }
}
