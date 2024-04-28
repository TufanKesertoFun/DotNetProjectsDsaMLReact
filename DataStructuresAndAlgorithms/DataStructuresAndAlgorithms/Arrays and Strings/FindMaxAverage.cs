using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
    public class FindMaxAverage
    {
        public double FindMaxAverageSolution(int[] nums, int k)
        {
            double sum = 0;

            for(int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            double maxSum = sum;

            for(int i = k; i <nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum / k;

        }
    }
}
