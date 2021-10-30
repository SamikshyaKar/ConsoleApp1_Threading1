using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
   public  class Thread4_kud
    {
        public static void Display_Myfunction()
        {
            Console.WriteLine();
            myfunction();
            Console.WriteLine(" Please enter a number ");
            object target = Console.ReadLine();
            Thread t1 = new Thread(myfunction1);
            t1.Start(target);
            Console.WriteLine(" Please ENTER SECOND NUMBER ");
            object target1 = Console.ReadLine();
            ParameterizedThreadStart p = new ParameterizedThreadStart(myfunction1);
            Thread t2 = new Thread(p);
            t2.Start(target1);
            Console.WriteLine();
        }

        public static void myfunction()
        {
            Console.WriteLine(" MYFUNCTIOn SIMPLE : MAIN THREAD ");
            Console.WriteLine(" THE ODD NUMBERS ");
            int i = 0;
            do
            {
                if (!(i % 2 == 0))
                {
                    Console.Write(" " + i);
                }
                i++;
            } while (i <= 30);

            Console.WriteLine();
        }

        public static void myfunction1(object target)
        {
            int num = 0;
            if (int.TryParse(target.ToString(), out num))
            {
                int i = 0;
                do
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(" " + i);
                    }
                    i++;
                } while (i <= num);

                Console.WriteLine();
            }
        }

    }
}
