using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
    public static class SlidingWindow
    {

        public static int FindLength(int[] nums, int k)
        {
            int left = 0;
            int curr = 0;
            int ans = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                curr += nums[right];
                while (curr > k)
                {
                    curr -= nums[left];
                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            return ans;
        }

        public static int FindLength(string s)
        {
            int left = 0;
            int curr = 0;
            int ans = 0;

            for(int right = 0; right < s.Length; right++)
            {
                if (s[right] == '0')
                {
                    curr++;
                }

                while (curr > 1)
                {
                    if (s[left] == '0')
                    {
                        curr--;
                    }

                    left++;
                }

                ans = Math.Max(ans, right - left + 1);
            }

            Console.WriteLine(ans);
            return ans;
        }
    }
}
