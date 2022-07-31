using System;

namespace uc3
{
    class Program
    {


        static void Main(string[] args)
        {
            int is_Full_Time = 1;
            int wage = 20;
            int emphr;
            Random random = new Random();
            int value = random.Next(0, 2);

            if (value == is_Full_Time)
            {
                emphr = 8;
                Console.WriteLine("The Employee is Fulltime and Wage is =" + (wage * emphr));
            }
            else
            {
                emphr = 4;
                Console.WriteLine("The Employee is parttime and Wage is =" + (wage * emphr));
            }
        }

    }

}

