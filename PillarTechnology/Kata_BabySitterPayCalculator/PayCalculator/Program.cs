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
        public static int WageCalc(int hours, int beforeBedTimeHours)
        {
            int AfterBedTimeHours = hours - beforeBedTimeHours;
            int pay = (beforeBedTimeHours * 12) + (AfterBedTimeHours * 8);
            return pay;
        }
    }
}
