using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.TomAndJerry
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cat("Tom");

            var m1 = new Mouse(c, "Jerry1");
            var m2 = new Mouse(c, "Jerry2");
            c.Call();

            Console.ReadKey();
        }
    }
}
