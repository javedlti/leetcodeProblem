using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class JumpingOnCloud
    {
        public int JumingOnCloud(int[] c, int k)
        {
            int[] cloud = c;
            int jumpSize = k;
            int energy = 100;
            int position = 0;
            int completed = 0;
            do
            {
                position = position + jumpSize;

                if (position >= cloud.Length)
                {
                    position = position - cloud.Length;
                }

                energy = EnegryCalculation(cloud, position, energy);
                if(position==0)
                {
                    completed = 1;
                }
            }
            while (energy > 0 && position <= cloud.Length && completed==0);

            return energy;
        }

        private int EnegryCalculation(int[] cloud, int position, int energy)
        {
            if (cloud[position] == 1)
            {
                energy = energy-1 - 2;
            }
            else
            {
                energy = energy - 1;
            }
            return energy;
        }
    }
}
