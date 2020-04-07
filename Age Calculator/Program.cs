using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Birthdate in the format mm/dd//yyyy");
            DateTime birthdate = new DateTime(0, 0, 0);

            //DateTime bday = new DateTime(1997, 07, 13);
            Console.ReadLine();

            DateTime today = DateTime.Today;

            //TimeSpan age = today.Subtract(birthdate);

            //Console.WriteLine(age);
            //Console.WriteLine("age in years={0}", age);
            //Console.WriteLine("age in months={0}", age);
            //Console.WriteLine("age in days={0}", age);

            //DateTime age = (today.Year - birthdate.Year);


            int ageYear = (today.Year - birthdate.Year);
            int ageMonth = (today.Month - (-birthdate.Month));
            int ageDay = (today.Day - birthdate.Day);
            ////int ageHour = (today.Hour - birthdate.Hour);
            ////int ageMinute = (today.Minute - birthdate.Minute);
            ////int ageSecond = (today.Second - birthdate.Second);

            Console.WriteLine("age in years={0}", ageYear);
            Console.WriteLine("age in months={0}", ageMonth);
            Console.WriteLine("age in days={0}", ageDay);






        }
    }
}
