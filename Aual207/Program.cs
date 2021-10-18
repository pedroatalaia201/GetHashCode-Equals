using System;

namespace Aual207
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));
            //OUTPUT: false;

            string c = "Jhon";
            string d = "Bob";

            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());
            //This will return a int value;
        }
    }
}
