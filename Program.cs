using System;

namespace uc3
{
    class Program
    {
        public const int is_Full_Time = 0;
        public const int is_Part_Time = 1;
        public const int per_hour_Wage = 20;

        static void Main(string[] args)
        {
            int emphr;
            Random random = new Random();
            int value = random.Next(0, 2);

            switch (value)
            {
                case is_Full_Time:
                    emphr = 8;
                    Console.WriteLine("The FullTime Emp Wage is =" + (per_hour_Wage * emphr));
                    break;
                case is_Part_Time:
                    emphr = 4;
                    Console.WriteLine("The PartTime Emp Wage is =" + (per_hour_Wage * emphr));
                    break;
                default:
                    emphr = 0;
                    break;

            }

        }

    }
}
