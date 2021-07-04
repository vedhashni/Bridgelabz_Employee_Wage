using System;

namespace Employee_Wage_Computation_Problem
{
    class Program
    {
        public const int full_time = 1;
        public const int part_time = 2;
        public string company;
        public int WAGE_PER_HOUR;
        public int total_workinghour;
        public int total_workingdays;
        public int wage_perhour;
        public Program(string company, int wage_perhour, int total_workingdays, int total_workinghour)
        {
            this.company = company;
            this.wage_perhour = wage_perhour;
            this.total_workingdays = total_workingdays;
            this.total_workinghour = total_workinghour;
        }
        public  void ComputeWage()
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
                        Console.WriteLine("Employee is present for part-time");
                        empHours = 8;
                        break;
                    case part_time:
                        Console.WriteLine("Employee is present for part-time");
                        empHours = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHours = 0;
                        break;
                }
                empPerDayWage = empHours * wage_perhour;
                empTotalWage += empPerDayWage;
                if (employeeAttendance > 0)
                {
                    empTotalWorkingday += 1;
                }
                empTotalWorkingHour += empHours;
            }
            Console.WriteLine("Company Name:" + company);
            Console.WriteLine("Working Hours :" + empTotalWorkingHour);
            Console.WriteLine("Employee Wage Per day :" + empPerDayWage);
            Console.WriteLine("Working days in a month :" + empTotalWorkingday);
            Console.WriteLine("Employee Wage for 20 working days :" + empTotalWage);

        }

        static void Main(string[] args)
        {
            Program TVSNext = new Program("TVSNext", 55, 12, 60);
            TVSNext.ComputeWage();
            Program Zoho = new Program("Zoho", 85, 52, 90);
            Zoho.ComputeWage();
            Program CTS = new Program("CTS", 65, 40, 70);
            CTS.ComputeWage();
        }
    }
}

