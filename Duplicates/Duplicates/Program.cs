using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 4, 3, 2, 7, 8, 2, 3, 1 };
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[array[i] % array.Length] = array[array[i] % array.Length] + array.Length;
            }
            //Console.WriteLine("The repeating elements are : ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= array.Length * 2)
                {
                    count++;
                    //Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine(string.Format("The total number of duplicate elements in an array are : {0}", count));
            Console.ReadKey();
        }
    }
}
