using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Tutorial.MANSI
{
        class MANSI_AGE_CALCULATOR
    {
        static void Main(String[] args)
        {
            int bdate, bmonth, byear, cdate, cmonth, cyear, date, month, year;

            Console.WriteLine("ENTER THE PRESENT DATE");
            cdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE BIRTH DATE");
            bdate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE PRESENT MONTH");
            cmonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE BIRTH MONTH");
            bmonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE PRESENT YEAR");
            cyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE BIRTH YEAR");
            byear = Convert.ToInt32(Console.ReadLine());

            date = cdate - bdate;
            month = cmonth - bmonth;
            year = cyear - byear;
            {
                Console.WriteLine("my age is " + year);
                Console.WriteLine("my month is " + month);
                Console.WriteLine("my date is " + date);
            }
            Console.ReadKey();

        }

    } }

