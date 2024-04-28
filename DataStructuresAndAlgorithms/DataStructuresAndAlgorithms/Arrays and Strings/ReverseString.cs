using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
   public static class ReverseString
    {
       public static char[] ReverseStringSolution(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while(left < right)
            {
                char temp = s[left];
                s[left++] = s[right];
                s[right--] = temp;
            }
            Console.Write(s);
            return s;
        }
        
    }
    
}
