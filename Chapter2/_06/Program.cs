using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = new FullName("john", "smith");
            Console.WriteLine(fullname.LastName);
        }
    }
}
