using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Employee_wage = 0;
            int emphr;
            int wage = 20;
            int dailyWage;
            int days = 20;
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == Employee_wage)
            {
                emphr = 100;
                Console.WriteLine("The Employee Wage for 100hrs is " + (emphr * wage));
            }
            else
            {
                emphr = 8;
                days = 20;
                dailyWage = (emphr * wage);
                Console.WriteLine("The Employee Wage for 20days is " + (days * dailyWage));
            }
        }
    }
}