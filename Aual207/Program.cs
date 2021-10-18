using System;
using Aual207.Entities;

namespace Aual207
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@email.com" };
            Client b = new Client { Name = "Alex", Email = "alex@email.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); //OUTPUT: False, == compara o ponteiro dos objetos(referencia de memoria);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
