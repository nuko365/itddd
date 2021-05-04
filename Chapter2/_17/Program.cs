using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameA = new FullName("masanobu", "naruse");
            var nameB = new FullName("john", "smith");

            var compareReuslt = nameA.Equals(nameB);
            Console.WriteLine(compareReuslt);

            var compareResult2 = nameA == nameB;
            Console.WriteLine(compareResult2);
        }
    }
}
