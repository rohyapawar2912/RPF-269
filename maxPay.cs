using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpPay
{
    internal class maxPay
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public static void PayScale()
        {
            int No_Of_Working_Days = 20;
            int Max_No_Of_Working_Hours = 100;
            int Wage_Per_Hr = Convert.ToInt32(Console.ReadLine());
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= Max_No_Of_Working_Hours && totalWorkingDays < No_Of_Working_Days)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case Is_Part_Time:
                        empHrs = 4;
                        break;
                    case Is_Full_Time:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + "Emp hours: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Wage_Per_Hr;
            Console.WriteLine("Total Emp Wage: " + totalEmpWage);
        }
    }
}
