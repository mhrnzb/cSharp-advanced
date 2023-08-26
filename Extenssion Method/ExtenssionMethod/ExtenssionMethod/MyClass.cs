using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExtenssionMethod
{       // برای استفاده از اکستنشتن متد ، هم کلاس ، هم متد تعریف شده باید از نوع استاتیک باشد .
        //اکستنشن متد فلش رو به پایین دارد

    public static class MyClass
    {
        public static string ToRial(this int value)
        {

            // اگه قصد داری که به جای متد یک اکستنشن متد ایجاد کنی ، کافیه که قبل از تعریف آرگومان ها ، یک this قرار بدی
            return value.ToString("# , 0 Tooman");
        }

        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) +"/" + pc.GetMonth(value).ToString("00")+"/"+ pc.GetDayOfMonth(value).ToString("00");
        }



    }
}
