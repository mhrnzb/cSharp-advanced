﻿using System;
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


            Console.WriteLine("================== Sorted by age : ==================");

            var result2 = people.OrderByDescending(p => p.age).ToList();
            foreach (var p in result2)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.family} Age : {p.age}");
            }


            Console.WriteLine("================== Show special Name : ==================");

            var result3 = people.Where(p => p.Name.ToLower() == "mehrnaz").ToList();
            foreach (var p in result3)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.family} Age : {p.age}");
            }

            Console.WriteLine("================== Show special Age : ==================");

            var result4 = people.Where(p => p.age>25 && p.age<40).ToList();
            foreach (var p in result4)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.family} Age : {p.age}");
            }


            Console.WriteLine("================== to extrcat Name  : ==================");

            var result5 = people.Select(p => p.Name).ToList();
            var result6 = people.Select(p => new { p.Name, p.age }).ToList();
            foreach (var p in result4)
            {
                Console.WriteLine($"ID : {p.PersonID} Name : {p.Name} Family : {p.family} Age : {p.age}");
            }

            //collection initializer

            List<PersonCar> Cars = new List<PersonCar>()
            {
                new PersonCar() {PersonID = 1 , CarName = "Pride" , CarModel=1380},
                new PersonCar() {PersonID = 3 , CarName = "Prykan" , CarModel=1382}
            };

            //join

            var join = (from p in people join c in Cars 
                        on p.PersonID equals c.PersonID 
                        select new {p.PersonID , p.Name ,p.family , p.age , c.CarName , c.CarModel}).ToList();
            Console.ReadKey();

            // we have 101 linq expression that you can use


            int[] numbers = { 1, 1, 2, 3, 4, 9, 10, 15, 15, 20, 25 };
            var res1 = numbers.Distinct().ToArray();


            var res2 = numbers.OrderByDescending(n => n).Take(3).ToArray();

            var res3 = numbers.OrderByDescending(n => n).Skip(3).ToArray();

            var res3 = numbers.OrderByDescending(n => n).Skip(3).Take(3).ToArray();

        }
    }
}
