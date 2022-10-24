using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    /// <summary>
    /// Let s is a substring of a string of length n then find occurance of a in string
    /// For eg: if substring s=abc and length n=10 then string will be abcabcabca and 
    /// Output = Count of a i.e. :4 
    /// </summary>
    public class HR_RepeatedString
    {
        public int CountACharRepeatedString(char charInput, string substr,int lenthofstring)
        {
           
            int TotalCharInSubstr=CharInString(charInput, substr);
           
            int countOfchar;
            int occuranceofSubstr = 1;
            
            if (substr.Length == lenthofstring)
                occuranceofSubstr = 1;
            else
                occuranceofSubstr = lenthofstring / substr.Length;
            
            int remainingstrLength = lenthofstring - (substr.Length * occuranceofSubstr);
            
            countOfchar = TotalCharInSubstr * occuranceofSubstr;
            
            if(remainingstrLength>0)
            {
               var newSubStr=substr.Substring(0, remainingstrLength);
               countOfchar += CharInString(charInput, newSubStr);
            }
            return countOfchar;
        }

        private int CharInString(char charInput,string str)
        {
            if(!str.Contains(charInput))
            {
                return 0;
            }
            else
            {
                char[] arr = str.ToCharArray();
                return arr.Where(x => x.Equals(charInput)).Count();
            }
        }
    }
}
