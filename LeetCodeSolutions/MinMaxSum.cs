using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class MinMaxSum
    {
        public static void MinMaxSumCalcularion(List<int> arr)
        {
            int sizeofList = arr.Count();
            arr.Sort();

            long minsum = 0, maxsum = 0;
            for(int i=0;i<= sizeofList - 2;i++)
            {
                minsum += arr.ElementAt(i);
            }
            for(int i= sizeofList - 1;i>0;i--)
            {
                maxsum += arr.ElementAt(i);
            }
            Console.WriteLine($"{minsum},{maxsum}");


        }
    }
}
