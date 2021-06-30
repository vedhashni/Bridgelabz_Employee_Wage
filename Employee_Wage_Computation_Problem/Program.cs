using System;

namespace Employee_Wage_Computation_Problem
{
    class Program
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public const int total_workingdays = 20;
        public const int wage_perhour = 20;
        public const int total_workinghour = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee_Wage_Computation!");
            int empHours = 0;
            int empTotalWorkingday = 1;
            int empTotalWorkingHour = 0;
            int empPerDayWage = 0;
            int empTotalWage = 0;
            Random random = new Random();
            while (empTotalWorkingday <= total_workingdays && empTotalWorkingHour <= total_workinghour)
            {
                int employeeAttendance = random.Next(0, 3);
                switch (employeeAttendance)
                {
                    case full_time:
                        empHours = 8;
                        break;
                    case part_time:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                empPerDayWage = empHours * wage_perhour;
                empTotalWage += empPerDayWage;
            }
        }
    }
}
