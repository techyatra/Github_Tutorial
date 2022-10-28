using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Github_Tutorial.Anshul
{
    public class Age
    {
        public int current_date = 27;
        public int current_month = 10;
        public int current_year = 2022;              // Query -> Const access in main , Public because it is needed in main
        int result_date, result_month, result_year;

        public void logic(int date, int month, int year, int month_day, int total_month)
        {
            if (current_month <= month && current_date < date)
            {
                result_year = current_year - year - 1;

                if (current_month == month)
                {
                    result_month = total_month - month + current_month - 1;
                }
                else
                {
                    result_month = total_month - month + current_month;
                }

                result_date = month_day - date + current_date;

                Console.WriteLine($"You are {result_year} years {result_month} months {result_date} days old");
            }

            else if (current_month >= month && current_date > date)
            {
                result_year = current_year - year;

                if (current_month == month)
                {
                    result_month = 0;
                }
                else
                {
                    result_month = current_month - month;
                }

                result_date = current_date - date;
                Console.WriteLine($"You are {result_year} years {result_month} months {result_date} days old");
            }

            else if (current_month < month && current_date > date)
            {
                result_year = current_year - year - 1;
                result_month = total_month - month + current_month;
                result_date = current_date - date;
                Console.WriteLine($"You are {result_year} years {result_month} months {result_date} days old");
            }

            else if (current_month > month && current_date < date)
            {
                result_year = current_year - year;
                result_month = current_month - month - 1;
                result_date = month_day - date + current_date;
                Console.WriteLine($"You are {result_year} years {result_month} months {result_date} days old");
            }

            else
            {
                result_year = current_year - year;
                Console.WriteLine($"You are {result_year} years {result_month} months {result_date} days old");
            }

        }
    }     
}

