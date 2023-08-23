﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linq

            //Select * From person as p 

            //p is alias

            // Linq structure : 
            // From  p in person  Select p 

            int[] numbers = { 1, 3 , 5 , 7 ,9 , 10 , 15 , 20 , 25 , 34 , 46 , 50 , 60 , 70 , 80 ,100 };

            int[] result1 = (from n in numbers select n).ToArray();

            int[] result2 = (from n in numbers orderby n descending select n).ToArray();

            int[] result3 = (from n in numbers where n>30 select n).ToArray();


             


        }
    }
}
