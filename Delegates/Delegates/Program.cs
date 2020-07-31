using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int ResultCalc(int n);

    class Program
    {
        static int result = 0;
        public static int RightAnswer(int a)
        {
            result += a;
            return result;
        }

        public static int WrongAnswer(int b)
        {
            result -= b;
            return result;
        }
        public static int getResult()
        {
            return result;
        }

        static void Main(string[] args)
        {
            ResultCalc rightAns = new ResultCalc(RightAnswer);
            ResultCalc wrongAns = new ResultCalc(WrongAnswer);
            rightAns(2);
            rightAns(2);
            rightAns(2);
            rightAns(2);
            wrongAns(4);
            rightAns(2);
            Console.WriteLine("Result is: {0}", getResult());
            Console.ReadKey();
        }
    }
}
