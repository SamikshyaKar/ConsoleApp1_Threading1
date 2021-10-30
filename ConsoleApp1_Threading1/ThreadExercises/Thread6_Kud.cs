using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1_Threading1.ThreadExercises
{
    public delegate void SumofNumbersCallback(int sumofnumbers);
   public class Thread6_Kud
    {
        public static void PrintNums(int sumtotal)
        {
            Console.WriteLine();
            Console.WriteLine(" The Sum Total is " +sumtotal);
        }

        public static void Display_Sum()
        {
            Console.WriteLine(" Enter a number ");
            int target = int.Parse(Console.ReadLine());
            SumofNumbersCallback callback = new SumofNumbersCallback(PrintNums);

            NumberCallback obj = new NumberCallback(target,callback);

            Thread t1 = new Thread(new ThreadStart(obj.Printallnumbersum));
            t1.Start();

        }
    }

    public class NumberCallback
    {
        int _target;
        SumofNumbersCallback _sumofcallback;
        public NumberCallback(int Target, SumofNumbersCallback Sumofcallback)
        {
            this._target = Target;
            this._sumofcallback = Sumofcallback;
        }
        public void Printallnumbersum()
        {
            int sum = 0;
            for(int i=0; i<=_target; i++)
            {
                sum = sum + i;

            }
            if(_sumofcallback !=null)
            {
                _sumofcallback(sum);
            }

        }
    }
}
