using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_Full_Time = 0;
            int emphr;
            int wage = 20;
            int dailyWage;
            int days = 20;
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == is_Full_Time)
            {
                emphr = 8;
                dailyWage = (emphr * wage);
                Console.WriteLine("The Full_time Employee salary is " + (days * dailyWage));
            }
            else
            {
                emphr = 4;
                dailyWage = (emphr * wage);
                Console.WriteLine("The Part_time Employee salary is " + (days * dailyWage));
            }
        }
    }
}
