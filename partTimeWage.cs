using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partTimeAdd
{
    internal class partTimeWage
    {
        public static void GetPartTimeWage()
        {
            int Work_days_permonth = Convert.ToInt32(Console.ReadLine());
            int Wage_Per_Hr = Convert.ToInt32(Console.ReadLine());
            int Hours_per_day = 8;

            int HoursPerMonth = (Work_days_permonth * Hours_per_day);
            int WagePerMonth = (Wage_Per_Hr * HoursPerMonth);
            Console.WriteLine("Part time wage per month = " + WagePerMonth);
        }
    }
}
