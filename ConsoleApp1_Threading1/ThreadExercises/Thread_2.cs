using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
    public class Thread_2
    {
        public  void Somemethod()
        {
            int num1 = 0;
           int  num2 = 0;
            int num3 = 0;

            for(int i=0;i<10;i++)
            {
                lock(this)
                {
                    num1 = 1;
                    num2 = 1;
                    num3 = num1 / num2;
                    Console.WriteLine(num3 + "num3 " + num1 + " num1" + num2 + " num2" );
                    num1 = 0;
                    num2 = 0;
                }

            }


        }

        public static void display()
        {
            Thread_2 obj = new Thread_2();
            Thread t1 = new Thread(new ThreadStart(obj.Somemethod));
            t1.Start();
            obj.Somemethod();
            Console.ReadLine();

        }
    }

   
}
