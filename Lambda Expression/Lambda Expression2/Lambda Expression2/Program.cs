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

            //object initializer 
            Person p2 = new Person()
            {
                PersonID = 2,
                Name = "najmeh",
                family = "taheri",
                age = 21,
            };
            people.Add(p2);

            people.Add(new Person()
            {
                PersonID = 3,
                Name = "yeganah",
                family = "davarzani",
                age = 20,
            });


            var result = people.ToList ();

            foreach(var p in result)
            {
                Console.WriteLine ($"ID : {p.PersonID} Name : {p.Name} Family : {p.family} Age : {p.age}");
            }

            Console.ReadKey();
        }
    }
}
