using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Person> people = new List <Person> ();

            Person p1 = new Person ();
            p1.PersonID = 1;
            p1.Name = "mehrnaz";
            p1.family = "bagheri";
            p1.age = 20;
            people.Add (p1);

        }
    }
}
