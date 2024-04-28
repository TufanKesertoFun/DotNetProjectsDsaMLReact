using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
    public static class SortedSquares
    {
        public static int[] SortedSquaresSolutionOne(int[] A)
        {
            int N = A.Length;
            int[] ans = new int[N];

            if( 1 <= A.Length && A.Length <= Math.Pow(10, 4))
            {
                for (int i = 0; i < N; ++i)
                {
                    ans[i] = A[i] * A[i];
                }
                Array.Sort(ans);
            }
            

            
            return ans;
        }

        public static int[] SortedSquaresSolutionTwo(int[] A)
        {
            int N = A.Length;
            int[] ans = new int[N];

            int index = 0;
            if( 1 <= A.Length && A.Length <= Math.Pow(10, 4))
            {
                foreach (int i in A)
                {
                    ans[index++] = i * i;
                }
                Array.Sort(ans);
            }

            return ans;
        }

        public static int[] SortedSquaresWithoutAdditionalSpaces(int[] nums)
        {
            if (1 <= nums.Length && nums.Length <= Math.Pow(10, 4))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = nums[i] * nums[i];
                }
                Array.Sort(nums);
                return nums;
            }
            throw new ArgumentNullException("Invalid Argument");
        }

     public static int[] sortedSquaresWithTwoPointer(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int left = 0;
            int right = n - 1;
            for (int i = n - 1; i <= 0; i--)
            {
                int square;
                if (Math.Abs(nums[left]) < Math.Abs(nums[right]))
                {
                    square = nums[right];
                    right--;
                }
                else
                {
                    square = nums[left];
                    left++;
                }
                result[i] = square * square;
            }
            return result;
        }
    }
}
