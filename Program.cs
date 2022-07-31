using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int emp_present = 0;
            Random random = new Random();
            int value = random.Next(0, 1);
            if (value == emp_present)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
