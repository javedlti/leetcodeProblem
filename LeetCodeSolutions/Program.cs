﻿using System;
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
            Console.WriteLine("Hello");
            HR_RepeatedString hR_Repeated = new HR_RepeatedString();
            var output = hR_Repeated.CountACharRepeatedString('a', "ababc", 100);
            Console.WriteLine(output);
        }
    }
}
