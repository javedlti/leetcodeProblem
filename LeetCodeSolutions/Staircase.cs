using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class Staircase
    {
        public static void DrawStairCase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j >0; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1;k<=i;k++)
                {
                    Console.Write("#");
                }
                Console.Write("\n");

               
            }
        }
    }
}
