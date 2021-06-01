using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3OO
{
    static class MyExtensions
    {
        public static void Show(this Product product)
        {
            Console.WriteLine("*** " + product.Name + " ***");
        }
    }
}
