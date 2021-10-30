using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
   public  class Thread1_Kud1
    {

        public static void method1()
        {
            for (int i =0; i<10;i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i*i + " " );
            }
            Console.WriteLine();
            Console.WriteLine(" Entry to  Mythreadsleep");
            MythreadSleep();

            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+i) + " ");
            }
            Console.WriteLine();
            Console.WriteLine(" Exit from Mythreadsleep ");
        }

        private static void MythreadSleep()
        {
            Thread.Sleep(5000);
        }

        public static void display()
        {
            method1();
            method2();
            //Console.ReadLine();

        }

    }
}
