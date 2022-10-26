using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
   public class NumberLineJump
    {
        public static string JumpCalculation(int x1,int v1,int x2,int v2)
        {
            string result = string.Empty;
            if(x2>x1 && v2>v1)
            {
                return "NO";
            }
            else
            {
                int positionOf_X1 = x1;
                int positionof_X2 = x2;
               
                for(int i=1;i<=10000;i++)
                {
                    int x = positionOf_X1 + v1;
                    positionOf_X1 = x;
                    int y = positionof_X2 + v2;
                    positionof_X2 = y;
                    if(positionOf_X1==positionof_X2)
                    {
                        return "YES"; ;
                    }

                }
                return "NO";
            }

        }
    }
}
