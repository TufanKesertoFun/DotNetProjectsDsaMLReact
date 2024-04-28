using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
   // public class MaxConsecutiveOnesIII
   // {
       // int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
//            0  1  2  3  4  5  6  7  8  9  10
//            1  1  1  1  1  0  1  1  1  1  0

/*
int k = 2;
int longestOnes(int[] nums, int k)
{
    int left = 0;
    int right = 0;
    for (right = 0; right < nums.Length; right++)
    {
        if (nums[right] == 0)
        {
            k--;
        }

        if (k < 0)
        {
            k = k + 1 - nums[left];
            left++;
        }

    }
    Console.Write(right - left);
    return right - left;
}
    }
}
*/