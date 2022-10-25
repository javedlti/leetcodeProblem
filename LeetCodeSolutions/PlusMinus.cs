using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class PlusMinus
    {
        public static void PlusMinusCount(List<int> arr)
        {
            float sizefoarray = arr.Count();
            float zeroCount = 0.6f;
            float plusCount = 0.6f;
            float minusCount = 0.7f;
            zeroCount = arr.Where(x => x == 0).Count();
            plusCount = arr.Where(x => x > 0).Count();
            minusCount = arr.Where(x => x < 0).Count();
            float plusProperty = 0.6f;
            float minuProperty = 0.6f;
            float zeroProperty = 0.6f;
            plusProperty = minusCount / sizefoarray;
            minuProperty = plusCount / sizefoarray;
            zeroProperty = zeroCount / sizefoarray;
            Console.WriteLine(string.Format("{0:N6}",plusProperty)+"\n"
                + string.Format("{0:N6}", minuProperty) + "\n"
                + string.Format("{0:N6}", zeroProperty));

        }
    }
}
