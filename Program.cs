using Github_Tutorial.Anshul;
using System;

namespace Github_Tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int month_day = 0, total_month = 12;
            Console.Write("Enter your birth date : ");
            var date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth month : ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth year : ");
            var year = Convert.ToInt32(Console.ReadLine());

            var obj = new Age();

            switch (month)
            {
                case 1:
                    month_day = 31;
                    break;
                case 2:
                    if (year % 4 == 0)       // To find a year is leap simply divide by 4 if remainder 0 then it is leap 
                    {
                        month_day = 29;
                    }
                    else
                    {
                        month_day = 28;
                    }
                    break;
                case 3:
                    month_day = 31;
                    break;
                case 4:
                    month_day = 30;
                    break;
                case 5:
                    month_day = 31;
                    break;
                case 6:
                    month_day = 30;
                    break;
                case 7:
                    month_day = 31;
                    break;
                case 8:
                    month_day = 31;
                    break;
                case 9:
                    month_day = 30;
                    break;
                case 10:
                    month_day = 31;
                    break;
                case 11:
                    month_day = 30;
                    break;
                case 12:
                    month_day = 31;
                    break;
                default:
                    Console.WriteLine("Please enter valid Month number and again restart the program...");
                    break;
            }

            // This code is written for if user input greater DOB than current date 

            if (year == obj.current_year && month >= obj.current_month && date > obj.current_date)
            {
                Console.WriteLine("Date of Birth must be less than or equal to current date...");
            }
            else if(date < obj.current_date && month > obj.current_month && year == obj.current_year)
            {
                Console.WriteLine("Date of Birth must be less than or equal to current date...");
            }
            else if (year > obj.current_year)                // If user input future year number
            {
                Console.WriteLine("Date of Birth must be less than or equal to current date...");
            }
            else if(date > month_day)                        // If user input invalid date number
            {
                if(month_day == 0)
                {
                    // If month_day = 0 then i want to print nothing
                }
                else
                {
                    Console.WriteLine("Please enter valid Date number and again restart the program...");
                }
            }
            else
            {
                obj.logic(date, month, year, month_day, total_month);
            }
        }
    }
}
