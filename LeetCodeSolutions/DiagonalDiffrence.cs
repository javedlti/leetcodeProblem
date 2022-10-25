using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class DiagonalDiffrence
    {
        public static int DiagonalDiffrenceCal(List<List<int>> ar)
        {
            int result = 0;
            int firstdiagonalSum = 0;
            int seconddiagobalSum = 0;
            int size = ar.Count();
            for (int i = 0; i < size; i++)
            {

                firstdiagonalSum += ar.ElementAt(i).ElementAt(i);
                seconddiagobalSum += ar.ElementAt(size - 1-i).ElementAt(i);

            }

            result = Math.Abs(firstdiagonalSum - seconddiagobalSum);
            return result;
        }
    }
}
