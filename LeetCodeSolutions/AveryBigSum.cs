using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class AveryBigSum
    {
        public static long BigSum(List<long> ar)
        {
            long result = 0;

            foreach(var item in ar)
            {
                result += item;
            }

            return result;
        }

    }
}
