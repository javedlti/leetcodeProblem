using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class GradingProblem
    {
        public static List<int> GradCalculation(List<int> grades)
        {
            List<int> finalGrade=new List<int>();
            foreach(var grade in grades)
            {
                if (grade >= 38)
                {
                    int remineder = grade % 5;
                    int roundedGrade = 0;

                    if (5 - remineder >= 3)
                    {
                        roundedGrade = grade;
                    }
                    else
                    {
                        roundedGrade = grade + (5 - remineder);
                    }
                    finalGrade.Add(roundedGrade);
                }
                else
                {
                    finalGrade.Add(grade);
                }

            }
            return finalGrade;
        }
    }
}
