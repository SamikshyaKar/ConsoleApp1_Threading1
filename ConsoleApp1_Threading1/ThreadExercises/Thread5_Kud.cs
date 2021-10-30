using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
   public  class Thread5_Kud
    {
       public static void Display_Number()
        {
            Console.WriteLine(" Enter the Target ");
            int target = int.Parse(Console.ReadLine());

            Number obj = new Number(target);
            Thread t1 = new Thread(new ThreadStart(obj.PrintNumber));
            t1.Start();
        }
    }

    public class Number
    {
        int target_num;

        public Number(int NUM)
        {
            target_num = NUM;
        }
        public void PrintNumber()
        {

            for(int i=0;i<=target_num;i++)
            {

                Console.Write(" " +i);
            }
            Console.WriteLine();
        }

    }
}
