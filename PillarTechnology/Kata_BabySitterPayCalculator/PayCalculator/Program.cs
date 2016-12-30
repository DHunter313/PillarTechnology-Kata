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
          
        }
        public static int WageCalc(int hours, int beforeBedTimeHours, int after_MidNiteHours)
        {
            int AfterBedTimeHours_BeforeMidnite = hours - beforeBedTimeHours - after_MidNiteHours;
            int pay = (beforeBedTimeHours * 12) + (AfterBedTimeHours_BeforeMidnite * 8) + (after_MidNiteHours * 16);
            return pay;
        }
    }
}
