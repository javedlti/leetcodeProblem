using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class UtopianTree
    {
        public int LenthOfUtopianTree(int growthCycle)
        {
            int LengthofTrree=1;
            for(int i=1;i<=growthCycle;i++)
            {
                if(i==0||i%2==0)
                {
                    LengthofTrree += 1;
                }
                else
                {
                    LengthofTrree *= 2;
                }
            }
            return LengthofTrree;

        }

    }
}
