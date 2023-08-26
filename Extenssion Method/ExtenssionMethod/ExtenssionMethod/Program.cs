using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenssionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Amount = 25000;
            Console.WriteLine(Amount.ToString("#,0 Rial" ));

            Console.ReadKey();

        }
    }
}
