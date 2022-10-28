using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Tutorial.Swati
{
    internal class swati_age_calculate
    {
        static void Age_Calc(string[] args)
        {
            int bd, bm, by, cd, cm, cy, dd, mm, yy;
            //int year, month, day;
            Console.WriteLine("enter the present day");
            cd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the birth day");
            bd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the present month");
            cm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the birth month");
            bm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the present year");
            cy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the birth year");
            by = Convert.ToInt32(Console.ReadLine());

            dd = cd - bd;
            mm = cm - bm;
            yy = cy - by;
            {
                Console.WriteLine("your age is " + yy);
                Console.WriteLine("month is " + mm);
                Console.WriteLine("day is " + dd);
            }

            Console.ReadKey();
        }
    }
}
