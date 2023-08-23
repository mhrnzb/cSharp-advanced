using System;
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

            int[] result3 = (from n in numbers where n>30 && n<80 
                             orderby n descending select n).ToArray();

            int result4 = (from n in numbers where n == 3 select n).First();

            int result5 = (from n in numbers where n == 2 select n).FirstOrDefault();


            int result6 = (from n in numbers where n == 3 select n).Single();

            int result7 = (from n in numbers where n == 2 select n).SingleOrDefault();


            //var is annonumous data type that added with LINQ
            // اولین مقداری که بگیره ، نوعش را مشخص می کند و برای دستورات لینک از آن استفاده می شود 
            var I1 = 123;
            var I2 = "Mehrnaz Bagheri";

            // اگه مثلا یه سایتی داشته باشی که کاربر در قسمت ثبت نام نتونه ایمیل تکراری وارد کنه ، به ضیوه ی زیر عمل می کنیم 

            bool result8 = (from n in numbers where n == 2 select n).Any();


            int count = (from n in numbers select n).Count();

            // بزرگترین عضو
            int Max = (from n in numbers select n).Max(); 
            // کوچکترین عضو
            int Min = (from n in numbers select n).Min();
            //حمع اعضا 
            int Sum = (from n in numbers select n).Sum();

        }
    }
}
