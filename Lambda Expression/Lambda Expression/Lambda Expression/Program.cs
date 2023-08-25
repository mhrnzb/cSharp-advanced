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
            //lambda :
            var lambda6 = numbers.Single(n => n == 3);
            int result7 = (from n in numbers where n == 2 select n).SingleOrDefault();
            //lambda:
            var lambda7 = numbers.SingleOrDefault(n => n == 2);


           
            
            var I1 = 123;
            var I2 = "Mehrnaz Bagheri";

         

            bool result8 = (from n in numbers where n == 2 select n).Any();
            //lambda :
            var lambda8 = numbers.Any(n => n == 2);


            int count = (from n in numbers select n).Count();
            //lambda :
            var Count = numbers.Count();

            // بزرگترین عضو
            int Max = (from n in numbers select n).Max();
            //lambda :
            var max = numbers.Max();

            // کوچکترین عضو
            int Min = (from n in numbers select n).Min();
            //lambda :
            var min = numbers.Min();
            //حمع اعضا 
            int Sum = (from n in numbers select n).Sum();
            //lambda :
            var sum = numbers.Sum();


            List<string> Names = new List<string>();
            Names.Add("Mehrnaz");
            Names.Add("Najmeh");
            Names.Add("Yegeneh");
            Names.Add("Zeynab");
            Names.Add("Fatemeh");

            var res1 = (from n in Names select n).ToList();
            //lambda :
            var lam1 = Names.ToList();

            var res2 = (from n in Names where n.ToLower().Contains("m") select n).ToList();
            //lambda :
            var lam2 =Names.Where(n =>n.ToLower().Contains("m")).ToList();


            var res3 = (from n in Names where n.ToLower().StartsWith("m") select n).ToList();
            //lambda :
            var lam3 = Names.Where(n => n.ToLower().StartsWith("m")).ToList();


            var res4 = (from n in Names where n.ToLower().EndsWith("m") select n).ToList();
            //lambda :
            var lam4 = Names.Where(n => n.ToLower().EndsWith("m")).ToList();

        }
    }
}
