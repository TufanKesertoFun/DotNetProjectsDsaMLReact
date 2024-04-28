using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
    public class RunningSumOfOneDArray
    {
        public static int[] runningSum(int[] nums)
        {
            {
                int[] results = new int[nums.Length];
                results[0] = nums[0];

                for (int i = 1; i < nums.Length; i++)
                {
                    results[i] = nums[i] + results[i - 1];
                }

                return results;
            }
        }

        public static int[] runningSumWithoutAdditionalSpaces(int[] nums)
        {
            for(int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }
            return nums;
        }
    }
}
