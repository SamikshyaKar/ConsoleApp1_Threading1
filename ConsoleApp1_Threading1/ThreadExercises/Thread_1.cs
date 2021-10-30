using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
    public class Thread_1
    {
        public static void Fun1()
        {
            for (int i = 0; i < 10000; i++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Fun1 is " + i);
            }

        }

        public static void fun2() 
        { 
            
            for (int j = 0; j < 10000; j++)
            {
                Thread.Sleep(2000);
                Console.WriteLine("Fun2 is " + j);
            }
        }


        public static void display_threads1()
        {
            Thread t1 = new Thread(new ThreadStart(Fun1));
            Thread t2 = new Thread(new ThreadStart(fun2));
            t1.Start();
            t2.Start();
            

        }

        public static void display_threads2()
        {
            Thread t3 = new Thread(Fun1);
            Thread t4 = new Thread(fun2);
            t3.Start();
            t4.Start();

        }
    }
}
