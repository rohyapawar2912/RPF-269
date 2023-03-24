using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSalary
{
    internal class MonthlyWage
    {
        public const int Is_Part_Time = 1;
        public const int Is_Full_Time = 2;
        public static void EmpSalary()
        {
            int No_Of_Working_Days = 20;
            int Wage_Per_Hr = Convert.ToInt32(Console.ReadLine());
            int EmpWage = 0, EmpHrs = 0, TotalEmpWage = 0;

            for (int Day = 0; Day < No_Of_Working_Days; Day++)
            {
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case Is_Part_Time:
                        EmpHrs = 4;
                        break;
                    case Is_Full_Time:
                        EmpHrs = 8;
                        break;
                    default:
                        EmpHrs = 0;
                        break;
                }
                EmpWage = EmpHrs * Wage_Per_Hr;
                TotalEmpWage += EmpWage;
                Console.WriteLine("Emp Wage: " + EmpWage);
            }
            Console.WriteLine("Total Emp Wage: " + TotalEmpWage);
        }
    }
}
