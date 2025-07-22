using System;

namespace assigment_op01
{
    internal class Program
    {

        #region Q1

        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        #region
        #endregion

        #region
        #endregion

        #region
        #endregion

        static void Main(string[] args)
        {

            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);

            }
            #endregion



            #region
            #endregion


            #region
            #endregion


            #region
            #endregion


        }
    }
}