using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] numbers = { 1, 3, 5, 7, 9, 10, 15, 20, 25, 34, 46, 50, 60, 70, 80, 100 };

            int[] result1 = (from n in numbers select n).ToArray();

            //lambda :
            var lambda1 = numbers.ToArray();


            int[] result2 = (from n in numbers orderby n descending select n).ToArray();

            //lambda :
            var lambda2 = numbers.OrderByDescending(n => n).ToArray();

            int[] result3 = (from n in numbers
                             where n > 30 && n < 80
                             orderby n descending
                             select n).ToArray();
            //lambda :
            var lambda3 = numbers.Where(n => n > 30 && n < 80).OrderByDescending(n => n).ToArray();

            int result4 = (from n in numbers where n == 3 select n).First();
            //lambda :
            var lambda4 = numbers.First(n => n==3);

            int result5 = (from n in numbers where n == 2 select n).FirstOrDefault();
            //lambda :
            var lambda5 = numbers.FirstOrDefault(n => n == 2);

            int result6 = (from n in numbers where n == 3 select n).Single();

            int result7 = (from n in numbers where n == 2 select n).SingleOrDefault();


           
            
            var I1 = 123;
            var I2 = "Mehrnaz Bagheri";

         

            bool result8 = (from n in numbers where n == 2 select n).Any();


            int count = (from n in numbers select n).Count();

            // بزرگترین عضو
            int Max = (from n in numbers select n).Max();
            // کوچکترین عضو
            int Min = (from n in numbers select n).Min();
            //حمع اعضا 
            int Sum = (from n in numbers select n).Sum();


            List<string> Names = new List<string>();
            Names.Add("Mehrnaz");
            Names.Add("Najmeh");
            Names.Add("Yegeneh");
            Names.Add("Zeynab");
            Names.Add("Fatemeh");

            var res1 = (from n in Names select n).ToList();

            var res2 = (from n in Names where n.ToLower().Contains("m") select n).ToList();


            var res3 = (from n in Names where n.ToLower().StartsWith("m") select n).ToList();



            var res4 = (from n in Names where n.ToLower().EndsWith("m") select n).ToList();


        }
    }
}
