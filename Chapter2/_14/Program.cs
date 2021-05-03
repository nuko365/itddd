using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameA = new FullName("masanobu", "naruse");
            var nameB = new FullName("masanobu", "naruse");

            Console.WriteLine(nameA.Equals(nameB));
        }
    }
}
