using System;
using System.Collections.Generic;
using System.Linq;

namespace TacoTuesday
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> years = new List<int>();

            int count = 0;      //The number of time Cinco de mayo is on a Tuesday
            int dayOfWeek = 3;  //Sunday is day 0, Saturday is day 6
            int julianDate = 1; //These are the initial conditions for 2020, which has Cinco de Mayo falling on a Taco Tuesday

            for (int i = 0; i < 36; i++)    //"i" is in years
            {
                if (i % 4 == 0)             // These will be the leap years, every 4 years
                {
                    for (int j = 1; j <= 366; j++)  //"j" is in days
                    {
                        dayOfWeek = dayOfWeek % 7;

                        if (dayOfWeek == 2 && julianDate % 365 == 126)
                        {
                            count++;
                            years.Add((i + 2020));
                        }

                        dayOfWeek++;
                        julianDate++;
                    }
                }
                else    //These will be the non-leap years
                {
                    for (int j = 1; j <= 365; j++) 
                    {
                        dayOfWeek = dayOfWeek % 7;

                        if (dayOfWeek == 2 && julianDate % 365 == 125)
                        {
                            count++;
                            years.Add((i + 2020));
                        }

                        dayOfWeek++;
                        julianDate++;
                    }
                }
                julianDate = 1;
            }
            Console.WriteLine($"There are {count} times where Cinco de Mayo falls on taco Tuesday: \n");

            foreach (var i in years)
            {
                Console.WriteLine(i);
            }
        }
    }
}
