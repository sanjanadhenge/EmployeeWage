using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
   class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeewage = new EmployeeWage();
            employeewage.DailyempWage("Reliance",20,20,100);
            employeewage.DailyempWage("Atos", 22, 18, 95);
            employeewage.DailyempWage("HCL", 24, 22, 102);
            employeewage.DailyempWage("BirlaSoft", 20, 25,92);

        }
    }
}
