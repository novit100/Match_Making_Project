using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriesToDELETE
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent mom1 = new Parent { age = 45, id = 1 };
            Console.WriteLine(mom1.id+" "+ mom1.age);
            Parent dad1 = new Parent { age = 50, id = 2 };
            Console.WriteLine(dad1.id+" "+dad1.age);
            Parent dad2 = new Parent { age = 40, id = 3 };
            Console.WriteLine(dad2.id + " " + dad2.age);

            Seeker son = new Seeker { id=10, dad = dad1, mom = mom1 };
            Console.WriteLine(son.id);
            Console.WriteLine(son.dad.id+" "+son.dad.age);
            Console.WriteLine(son.mom.id + " " + son.mom.age);
            Console.WriteLine("----------------------------------------");
            dad1.age = 100;
            Console.WriteLine(dad1.id + " " + dad1.age);
            Console.WriteLine(son.dad.id + " " + son.dad.age);
            Console.ReadKey();

        }
    }
}
