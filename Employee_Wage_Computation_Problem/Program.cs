using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage_Computation_Problem
{
    class Program
    {

        //Console.WriteLine("Welcome To Employee_Wage_Computation!");
        public const int full_time = 1;
        public const int part_time = 2;
        /*public string company;
        public int WAGE_PER_HOUR;
        public int total_workinghour;
        public int total_workingdays;
        public int wage_perhour;*/
        /*public Program(string company, int wage_perhour, int total_workingdays, int total_workinghour)
        {
            this.company = company;
            this.wage_perhour = wage_perhour;
            this.total_workingdays = total_workingdays;
            this.total_workinghour = total_workinghour;
        }*/
        public class EmpBuilderWage
        {

            //public const int FULL_TIME = 1;
            //public const int PART_TIME = 2;
            private int numberOfCompany = 0;
            private int employeeDailyWage = 0;
            private CompanyEmpWage[] companyEmpWageArray;
            private int totalWage;
            private int wagePerHour;
            public EmpBuilderWage()
            {
                //while (empTotalWorkingday <= total_workingdays && empTotalWorkingHour <= total_workinghour)
                this.companyEmpWageArray = new CompanyEmpWage[5];
            }
            public void addCompanyEmpWage(string company, int wagePerhour, int maxHoursPerMonth, int maxWorkingDays)
            {
                companyEmpWageArray[this.numberOfCompany] = new CompanyEmpWage(company, wagePerhour, maxHoursPerMonth, maxWorkingDays);
                numberOfCompany++;
            }
            public void ComputeEmpWage()
            {
                for (int i = 0; i < numberOfCompany; i++)
                {

                    companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                    Console.WriteLine(this.companyEmpWageArray[i].toString());

                }
                //empTotalWorkingHour += empHours;

            }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Console.WriteLine("Welcome to employee wage computation");
            //Creating a Random Function
            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0, workingHrs = 0;


            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays <= companyEmpWage.maxWorkingDays)
            {
                //Calling the next method in Random Class
                totalWorkingDays++;
                Random r = new Random();
                int empAttendance = r.Next(0, 3);
                switch (empAttendance)
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

                totalEmpHrs += empHours;

            }
        

        Console.WriteLine("Days : " + totalWorkingDays + " Emp Hours : " + empHours);
                return totalEmpHrs* companyEmpWage.wagePerHour;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to employee wage computation");
        EmpBuilderWage empBuilderWage = new EmpBuilderWage();
        empBuilderWage.addCompanyEmpWage("TCS", 20, 15, 10);
        empBuilderWage.addCompanyEmpWage("Accenture", 10, 20, 20);
        empBuilderWage.ComputeEmpWage();
    }


   
    }
}

