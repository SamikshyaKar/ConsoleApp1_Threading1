using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
   public class Thread2_kud
    {

        // offload the work to a worker thread and make the main thread free..
        public static void mythread1()
        {
            for(int i= 0; i<30;i++)
            {
                if(i%2==0)
                {
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine();
            //Console.WriteLine(" Entery to MythreadsleepNOT()" );
            //MythreadsleepNOT();
            //Console.WriteLine(" Exit from  MythreadsleepNOT()");
            Console.WriteLine(" Entry to the New thread T1");
            Thread t1 = new Thread(MythreadsleepNOT);
            t1.Start();
            Console.WriteLine(" Exit from t1 the Worker thread ");
            int j = 0;          
           
                while  ( j <=30)
                {
                if(j%2==0)
                    Console.Write(j + " ");
                j++;
            }           

            Console.WriteLine();
        }

        private static void MythreadsleepNOT()
        {
            Thread.Sleep(5000);
        }
    }
}
