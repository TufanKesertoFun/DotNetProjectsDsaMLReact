using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Arrays_and_Strings
{
    public class MaximumWealth1672()
    {
       public static int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;

            foreach (int[] customer in accounts)
            {
                int currentWealth = 0;

                foreach (int bank in customer) {
                    currentWealth += bank;

                }

                maxWealth = Math.Max(maxWealth, currentWealth);
            }
            
            return maxWealth;
        }

    }        

}
    


