using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = new FullName("masanobu", "naruse");
            Console.WriteLine(fullName.LastName);
            fullName.ChangeLastName("sato");
            Console.WriteLine(fullName.LastName);
        }
    }
}
