using Github_Tutorial.agetanmay.AGE_CALCULATION;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Github_Tutorial.agetanmay
{
       public class Agecalculator
    {


        public void UsersInputBirth()
        {

            Console.WriteLine("yur birth date");
            int Birth_date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yur birth month");
            int Birth_month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yur birth year");
            int Birth_year = Convert.ToInt32(Console.ReadLine());
        }

        public void CurrentData()
        {
            int Currentdate = DateTime.Now.Day;

            int Currentmonth = DateTime.Now.Month;

            int Currentyear = DateTime.Now.Year;
        }


        public void VerificationOfData(int Birth_year,int Birth_date,int Birth_month,int Currentyear)

        {
            if(Birth_year>Currentyear)
            {
                Console.WriteLine("this not possible so lets try again");

            }

            if(Birth_date>31)
            {
                Console.WriteLine("enter valid data:");
            }

            if(Birth_month>12)
            {
                Console.WriteLine("month are not more than 12 not valid");

            }


        }

        public void monthsdays(int months, int years)
        {
            int Daysmonth = 0;
            switch (months)
            {
                case 1: Daysmonth = 31; break;
                case 2: if (years % 4 == 0)
                    {
                        Daysmonth = 29;
                    }
                    else
                    {
                        Daysmonth = 29;
                    }
                    break;
                case 3: Daysmonth = 31; break;
                case 4: Daysmonth = 30; break;
                case 5: Daysmonth = 31; break;
                case 6: Daysmonth = 30; break;
                case 7: Daysmonth = 31; break;
                case 8: Daysmonth = 30; break;
                case 9: Daysmonth = 31; break;
                case 10: Daysmonth = 30; break;
                case 11: Daysmonth = 31; break;
                case 12: Daysmonth = 30; break;

                default:
                    Console.WriteLine("eneter validmonth");
                    break;
            }
        }


               public void UserAgeInYear(int Birth_year,int Current_year)
                    {
                       int Calcage = Birth_year - Current_year;
               Console.WriteLine("yur age is in year is:"+Calcage);

                    }

        public void UserAgeInDays(int Birth_month, int Currentmonth)
        {
            int CalDays= ((  Currentmonth - Birth_month) 
        }


            

        















            

        


        
        



        
            

                
   
        



            




            
            







           



        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth date :");
            int birth_date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yur birth month in no:");
            int birth_month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter yur birth year:");
            int birth_year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter  present date:");
            int present_date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter present month in no :");
            int present_month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter presnt year :");
            int present_year = Convert.ToInt32(Console.ReadLine());



            //  Program obj = new Program(H);
            


        }
    }
}

    }
}
