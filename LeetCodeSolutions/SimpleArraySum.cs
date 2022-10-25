using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
   public class SimpleArraySumCLass
    {
        public static int SimpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach(int i in ar)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
