using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Github_Tutorial.Anshul
{
    public class Age
    {
       public void TakeInputFromUsers()
        {
            Console.Write("Enter your birth date : ");
            int birthDate = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth month : ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your birth year : ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int currentYear = DateTime.Now.Year;  
            int currentMonth = DateTime.Now.Month;
            int currentDay = DateTime.Now.Day;
           /* DateMonthYearValidation(birthDate, birthMonth, birthYear, currentYear);
            AgeInYears(birthYear, currentYear);
            AgeInMonths(birthMonth, birthYear, currentMonth, currentYear);*/
        }

        public void DateMonthYearValidation(int birthDate, int birthMonth, int birthYear, int currentYear)
        {
            if (birthYear > currentYear)
                throw new Exception("Birth year can not be greater than current year");
            if (birthMonth > 12 || birthMonth < 0)
                throw new Exception("Invalid birth month");
            if (birthDate < 0 || birthDate > 31)
                throw new Exception("Invalid birth date");
            if (birthDate == 31 && (birthMonth == 2 || birthMonth == 4 || birthMonth == 6 || birthMonth == 9
                || birthMonth == 11))
                throw new Exception("Invalid birth date");
        }

        public int DaysInMonth(int month, int year)
        {
            int month_day = 0;
            switch (month)
            {
                case 1:
                    month_day = 31;
                    break;
                // To find a year is leap simply divide by 4 if remainder 0 then it is leap 
                case 2:
                    if (year % 4 == 0)       
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
            return month_day;
        }

        public void AgeInYears(int birthYear, int currentYear)
        {
            int ageInYears = currentYear - birthYear;
            Console.WriteLine("your age in year is " + ageInYears);
        }
        public void AgeInMonths(int birthMonth, int birthYear, int currentMonth, int currentYear)
        {
            int ageInMonths = ((currentYear - birthYear) - 2) + currentMonth + (12 - birthMonth + 1);
            Console.WriteLine("your age in months is  " + ageInMonths);
        }
        public void AgeInDays()

        {
            // complete this function
        }



    }
    }  
    


