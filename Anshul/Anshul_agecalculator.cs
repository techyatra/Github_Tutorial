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

            int currentYear = DateTime.Now.Month;  
            int currentMonth = DateTime.Now.Month;
            int currentDate = DateTime.Now.Day;

            DateMonthYearValidation(birthDate, birthMonth, birthYear, currentYear, currentMonth, currentDate);       
            FinalAge(birthDate, birthMonth, birthYear, currentDate, currentMonth, currentYear, DaysInMonth(birthMonth, birthYear));
          //  AgeInYears(birthYear, currentYear);
          //  AgeInMonths(birthMonth, birthYear, currentMonth, currentYear);          
        }

        public void DateMonthYearValidation(int birthDate, int birthMonth, int birthYear, int currentYear, int currentmonth, int currentdate)
        {
            /* if (birthYear > currentYear)
                 throw new Exception("Birth year can not be greater than current year");
             if (birthMonth > 12 || birthMonth < 0)
                 throw new Exception("Invalid birth month");
             if (birthDate < 0 || birthDate > 31)
                 throw new Exception("Invalid birth date");
             if (birthDate == 31 && (birthMonth == 2 || birthMonth == 4 || birthMonth == 6 || birthMonth == 9
                 || birthMonth == 11))
                 throw new Exception("Invalid birth date");     */

            if (birthYear == currentYear && birthMonth == currentmonth && birthDate > currentdate)
            {
                throw new Exception("Date of Birth cannot be greater than current date...");
            }            
            if (birthYear == currentYear && birthMonth > currentmonth)
            {
                throw new Exception("Date of Birth cannot be greater than current date...");
            }
            if (birthYear > currentYear || birthMonth > 12 || birthDate > DaysInMonth(birthMonth, birthYear))
            {
                throw new Exception("Invalid Birth Date/Month/Year...");
            }
            if(birthYear == 0 || birthMonth == 0 || birthDate == 0)
            {
                throw new Exception("Birth Date/Month/Year cannot be Zero...");
            }
        }
        public void FinalAge(int birthDate, int birthMonth, int birthYear, int currentDate, int currentMonth, int currentYear, int monthDay)
        {
            int resultYear, resultMonth, resultDate;
            if (currentMonth <= birthMonth && currentDate < birthDate)       // 5-12-2002
            {
                resultYear = currentYear - birthYear - 1;
                resultMonth = 12 - birthMonth + currentMonth - 1;

                /*  if (currentMonth == birthMonth)
                  {
                      resultMonth = 12 - birthMonth + currentMonth - 1;
                  }
                  else
                  {
                      resultMonth = 12 - birthMonth + currentMonth;
                  }       */

                resultDate = monthDay - birthDate + currentDate;
                Console.WriteLine($"You are {resultYear} years {resultMonth} months {resultDate} days old");
            }
            else if (currentMonth >= birthMonth && currentDate > birthDate)   // 10-8-2002 or 10-10-2002
            {
                resultYear = currentYear - birthYear;
                if (currentMonth == birthMonth)
                {
                    resultMonth = 0;
                }
                else
                {
                    resultMonth = currentMonth - birthMonth;
                }
                resultDate = currentDate - birthDate;
                Console.WriteLine($"You are {resultYear} years {resultMonth} months {resultDate} days old");
            }
            else if (currentMonth < birthMonth && currentDate >= birthDate)
            {
                resultYear = currentYear - birthYear - 1;
                resultMonth = 12 - birthMonth + currentMonth;
                resultDate = currentDate - birthDate;
                Console.WriteLine($"You are {resultYear} years {resultMonth} months {resultDate} days old");
            }
            else if (currentMonth > birthMonth && currentDate <= birthDate)
            {
                resultYear = currentYear - birthYear;
                if(birthDate == currentDate)
                {
                    resultMonth = currentMonth - birthMonth;
                    resultDate = currentDate - birthDate;
                }
                else
                {
                    resultMonth = currentMonth - birthMonth - 1;
                    resultDate = monthDay - birthDate + currentDate;
                }    
                Console.WriteLine($"You are {resultYear} years {resultMonth} months {resultDate} days old");
            }
            else
            {
                resultYear = currentYear - birthYear;
                resultMonth = currentMonth - birthMonth;
                resultDate = currentDate - birthDate;
                Console.WriteLine($"You are {resultYear} years {resultMonth} months {resultDate} days old");
            }
        }

        public int DaysInMonth(int birthmonth, int birthyear)
        {
            int monthDay = 0;
            switch (birthmonth)
            {
                case 1:
                    monthDay = 31;
                    break;
                // To find a year is leap simply divide by 4 if remainder 0 then it is leap 
                case 2:
                    if (birthyear % 4 == 0)       
                    {
                        monthDay = 29;
                    }
                    else
                    {
                        monthDay = 28;
                    }
                    break;
                case 3:
                    monthDay = 31;
                    break;
                case 4:
                    monthDay = 30;
                    break;
                case 5:
                    monthDay = 31;
                    break; 
                case 6:
                    monthDay = 30;
                    break;
                case 7:
                    monthDay = 31;
                    break;
                case 8:
                    monthDay = 31;
                    break;
                case 9:
                    monthDay = 30;
                    break;
                case 10:
                    monthDay = 31;
                    break;
                case 11:
                    monthDay = 30;
                    break;
                case 12:
                    monthDay = 31;
                    break;
                default:
                    throw new Exception("Birth Month cannot be greater than 12...");
                    break;
            }
            return monthDay;
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
    


