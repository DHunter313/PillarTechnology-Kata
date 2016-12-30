using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string start_over = "y";

            do
            {
                Console.WriteLine("Hello, Welcome to the Baby-Sitter Pay Calculator App \n\n");

                #region total hours
                Console.Write("Please input the total amount of hours you worked for the night. \nBe sure to only enter in numbers. (Example Hours: 10) \n\nHours: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                #endregion

                #region bedtime
                Console.Clear();
                Console.WriteLine("\nDid the child have a bedtime? ");
                string response_bedTime = Console.ReadLine();
                int beforeBedtime;

                if (response_bedTime == "y")
                {
                    Console.WriteLine(" Please enter in the amount of hours you worked before the sleep time. ");
                    Console.Write("Amount before bedtime: ");
                    beforeBedtime = Convert.ToInt32(Console.ReadLine());
                }

                else
                {
                    beforeBedtime = hours;
                }

                #endregion

                #region After Midnight
                Console.Clear();
                Console.Write("Did you work after midnight? 'y' or 'n' \n Response: "); var midnightResponse = Console.ReadLine();
                int afterMidnight;

                if (midnightResponse == "y")
                {
                    Console.WriteLine(" Please enter in the amount of hours you worked after midnight. ");
                    Console.Write("Amount after midnight: ");
                    afterMidnight = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    afterMidnight = 0;
                }
                #endregion

                #region Wage Calculation
                Console.Clear();
                int pay = WageCalc(hours, beforeBedtime, afterMidnight);

                Console.WriteLine($"Total Hours: {hours} \nTotal Pay = ${pay}");
                Console.WriteLine("\n\n Would you like to calculate again? (y or n)");
                #endregion

                start_over = Console.ReadLine();
            } while (start_over == "y");

            Console.WriteLine("\n\nThank You and Good-Bye");

        }
        public static int WageCalc(int hours, int beforeBedTimeHours, int after_MidNiteHours)
        {
            int AfterBedTimeHours_BeforeMidnite = hours - beforeBedTimeHours - after_MidNiteHours;
            int pay = (beforeBedTimeHours * 12) + (AfterBedTimeHours_BeforeMidnite * 8) + (after_MidNiteHours * 16);
            return pay;
        }
    }
}
