using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employeewage
    {
        const int Is_present = 1;
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
    }
}
