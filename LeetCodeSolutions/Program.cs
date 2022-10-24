using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //HR_RepeatedString hR_Repeated = new HR_RepeatedString();
            //var output = hR_Repeated.CountACharRepeatedString("ababc", 100);
            //Console.WriteLine(output);

            UtopianTree ut = new UtopianTree();
            var length= ut.LenthOfUtopianTree(3);
            Console.WriteLine(length);
            Console.ReadLine();
        }
    }
}
