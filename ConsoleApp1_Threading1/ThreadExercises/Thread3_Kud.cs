using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
   public  class Thread3_Kud
    {
        public  static void methodtesting()
        {
            Console.WriteLine("****** Entery to MethodTESTING FUNCTION ");
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");

                }

                i++;
            } while (i <= 30);

            Console.WriteLine();
            Console.WriteLine("****** Exit from MethodTESTING FUNCTION ");          

        }

        public  static void Methodtesting_Display()
        {
            Console.WriteLine();
            Console.WriteLine(" Entry to ThreadStart Delegate ");
            Thread t1 = new Thread(new ThreadStart(Thread3_Kud.methodtesting));
            t1.Start();
            Console.WriteLine(" Exit From ThreadStart Delegate ");
            Console.WriteLine();
            Console.WriteLine("          Use of Delegate ");
            Console.WriteLine();
            Thread t2 = new Thread(delegate () { Thread3_Kud.methodtesting(); });
            t2.Start();
            Console.WriteLine(" Exit from DELEGATE ");
            Console.WriteLine();
            Console.WriteLine("      Use of LAMBDA EXPRESION ");
            Thread t3 = new Thread(() => Thread3_Kud.methodtesting());
            t3.Start();
            Console.WriteLine("  Exit from LAMBDA Expression ");

        }      




    }
}
