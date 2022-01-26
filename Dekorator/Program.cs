using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator
{
    class Program
    {
        public static void Main(String[] args)
        {
            Room r1 = new Sheraton();
            Room r2 = new Mercure();

            Console.WriteLine("\nPokój ekonomiczny");
            Console.WriteLine(r1.description() + " " + r1.price());
            Console.WriteLine(r2.description() + " " + r2.price());

            //z telefonem

            r1 = new Phone(r1);
            r2 = new Phone(r2);
            Console.WriteLine("\nPokój z tefefonem");
            Console.WriteLine(r1.description() + " " + r1.price());
            Console.WriteLine(r2.description() + " " + r2.price());

            // z klimatyzacją

            r1 = new Air(r1);
            r2 = new Air(r2);
            Console.WriteLine("\nPokój z klimatyzacją i telefonem");
            Console.WriteLine(r1.description() + " " + r1.price());
            Console.WriteLine(r2.description() + " " + r2.price());
            Console.ReadKey();
        }
    }
}
