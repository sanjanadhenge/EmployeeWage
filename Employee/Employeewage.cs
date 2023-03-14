using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class EmployeeWage
    {
        const int Is_present = 1, Full_Day_Hr = 8, Part_Time_Hr = 4, Is_Full_Time = 0, Is_Part_Time = 1;
        public void Attendance()
        {
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == Is_present)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void DailyempWage(String CompanyName,int Wage_Per_Hr, int Total_working_days,int Total_Working_Hrs)
        {
            int empHrs = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            for (int i = 0; i < Total_working_days && empHrs< Total_Working_Hrs; i++) 
            {
                switch (check)
                {
                    case Is_Full_Time:
                        empHrs += Full_Day_Hr;
                        break;
                    case Is_Part_Time:
                        empHrs += Part_Time_Hr;
                        break;
                    default:
                        empHrs += 0;
                        break;

                }
            }
                int wage = Wage_Per_Hr * empHrs;
                 Console.WriteLine(CompanyName+"---->"+"Daily Wage =" + wage);
        }
        
    }
}
