using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
   public class CompareTheTriplet
    {
        public static List<int> CompareTriplet(List<int> a,List<int> b)
        {
            List<int> alice = a;
            List<int> bob = b;
            int aliceScore=0;
            int bobScore=0;
            for(int i=0;i<alice.Count;i++)
            {
                if(alice.ElementAt(i)>bob.ElementAt(i))
                {
                    aliceScore = aliceScore + 1;
                }
                else if(alice.ElementAt(i)<bob.ElementAt(i))
                {
                    bobScore = bobScore + 1;
                }
            }
            return new List<int> { aliceScore, bobScore };
        }
    }
}
