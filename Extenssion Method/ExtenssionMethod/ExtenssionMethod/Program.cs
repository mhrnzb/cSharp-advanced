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

            Console.WriteLine(MyClass.ToRial(Amount));
            Console.WriteLine(MyClass.ToRial(7895000));

            Console.WriteLine(Amount.ToRial());

            Console.WriteLine(5000.ToRial());

            Console.WriteLine(DateTime.Now.ToShamsi());
            Console.ReadKey();

        }
    }
}
