using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigment_op01
{
    internal class Program
    {

        #region Q1

        //enum WeekDays
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        #endregion

        #region Q2

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region
        #endregion

        #region
        #endregion

        static void Main(string[] args)
        {

            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);

            //}
            #endregion

            #region 2 - Create an Enum called "Seas on" with the four seasons(Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string input = Console.ReadLine();
            bool success = Enum.TryParse(input, true, out Season selectedSeason);
            if (success)
            {
                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                    default:
                        Console.WriteLine("Invalid season.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid season name.");
            }


            #endregion


            #region
            #endregion


            #region
            #endregion


        }
    }
}