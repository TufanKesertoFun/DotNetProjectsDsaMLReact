using DataStructuresAndAlgorithms.Arrays_and_Strings;
using System.Formats.Asn1;

//Console.WriteLine("Hello, World!");

/*ReverseString.ReverseStringSolution(['h', 'e', 'l', 'l', 'o']);
SortedSquares.SortedSquaresSolutionOne([-7, -3, 2, 3, 11]);
SortedSquares.SortedSquaresSolutionTwo([-7, -3, 2, 3, 11]); 
SlidingWindow.FindLength("001"); 

RunningSumOfOneDArray.runningSum([1, 2, 3, 4]); */

/*
MaximumWealth1672.MaximumWealth([[1, 5], [1, 11]]);
*/

/*

List<string> list = new List<string>() { "1", "2", "3" };
List<string> list2 = new List<string>();


for(int i = 0; i < list.Count; i++)
{
    list2.Add(list[list.Count - 1 -i]);
}

foreach(var item in list2)
{
    Console.WriteLine(item);
} */

/*
ReverseString.ReverseStringSolution(['h', 'e', 'l', 'l', 'o']);
*/

/*
int[] FirstPalindrome(string s)
{
    int minValue = 0;
    int maxValue = s.Length;
    int len = s.Length;
    int[] result = new int[len + 1];
    int sum = 0;
    int expectedSum = 0;
    int finalValue = expectedSum - sum;

    for (int i = 0; i < len; i++)
    {
        if (s[i] == 'D')
        {
            result[i] += maxValue;
            maxValue--;
        }
        else
        {
            result[i] += minValue;
            minValue++;
        }
    }

    foreach (int value in result)
    {
        sum += result[value];
    }

    for (int i = 0; i < len; i++)
    {
        expectedSum += len - i + 1;
    }

    result[len] = finalValue;

    return result;
}


    FirstPalindrome("IDID");
 
*/

/*
int?[] arr = { 4, 1, 5, 6, 7, 8, 10, 2, -10, -1, null, null, null };

bool isElementPresent(int?[] arr, int N, int x)
{
    
    arr[N] = x; //MaxIntegerValue
    int i = 0;
    while (arr[i] != x)
    {
        i++;
        if (i == N) return false;
    }
    return true;
}

isElementPresent(arr, 10, 8);


bool isElementPresent2(int?[] arr, int N)
{
    int x = int.MaxValue;
    arr[N] = x;
    int i = 0;
    while (arr[i] != x)
    {
        i++;
        if (i == N) return false;
    }
    return true;
}

isElementPresent2(arr, 10);

*/


/*
Console.Write("Enter the number of rows for Pascal's Triangle: ");
int numRows = Convert.ToInt32(Console.ReadLine());

int[][] pascalsTriangle = GeneratePascalsTriangle(numRows);


foreach (var row in pascalsTriangle)
{
    foreach (var value in row)
    {
        Console.Write(value + " ");
    }
    Console.WriteLine();
}

static int[][] GeneratePascalsTriangle(int numRows)
{
    int[][] triangle = new int[numRows][];

    for (int i = 0; i < numRows; i++)
    {
        triangle[i] = new int[i + 1];
        int currentValue = 1;

        for (int j = 0; j <= i; j++)
        {
            triangle[i][j] = currentValue;
            currentValue = currentValue * (i - j) / (j + 1);
        }
    }

    return triangle;
}*/


//ReverseString.ReverseStringSolution(['h', 'e', 'l', 'l', 'o']);

/*
int[] nums = { 3, 1, 2, 7, 4, 2, 1, 1, 5 };
int k = 8;

int sum = 0;
int left = 0;
int answer = 0;

for(int right = 0; right < nums.Length; right++)
{
    sum += nums[right];
    
    while(sum > k)
    {
        sum -= nums[left];
        left++;
    }

    answer = Math.Max(answer, right - left + 1);
}
Console.WriteLine(answer);
*/

/*
int[] nums = { 3, 1, 2, 7, 4, 2, 1, 1, 5 };
int k = 8;
 int findLength(int[] nums, int k)
{
    int left = 0;
    int curr = 0; // curr is the current sum of the window
    int ans = 0;

    for (int right = 0; right < nums.Length; right++)
    {
        curr += nums[right];
        while (curr > k)
        {
            curr -= nums[left];
            left++;
        }
        if (curr == k)
        {
            ans = Math.Max(ans, right - left + 1);
            Console.WriteLine(ans);
            return ans;
        }
        
    }
    throw new InvalidDataException("Invalid Data Excepiton");


}
findLength(nums, k);
*/
/*
int[] nums = { 3, 1, 2, 7, 4, 6, 1, 0, 5,8 };
int k = 8;
int findLength(int[] nums, int k)
{
    int left = 0;
    int currentTotal = 0;
    int ans = 0;

    for (int right = 0; right < nums.Length; right++)
    {
        currentTotal += nums[right];
        while (currentTotal > k)
        {
            currentTotal -= nums[left];
            left++;
        }

        if (currentTotal == k)
        {
            ans = Math.Max(ans, right - left + 1);
            Console.WriteLine(ans);
            return ans;
        }
    }
    throw new Exception("Invalid Argument");

}

findLength(nums, k); */

/*
int[] sum = [1, 12, -5, -6, 50, 3];
int k = 4;
int n = 0;
Console.Write(sum[4 - 4]);
Console.Write(sum[5 - 4]);
*/


/*
int[] nums = [1];
int k = 1;
int n = nums.Length;
double sum = 0;
 double FindMaxAverage(int[] nums, int k)
{
    int n = nums.Length;
    double sum = 0;

    for (int i = 0; i < k; i++)
    {
        sum += nums[i];
    }

    double maxSum = sum;

    for (int i = k; i < n; i++)
    {
        sum += nums[i] - nums[i - k];
        maxSum = Math.Max(maxSum, sum);
    }
    
    return maxSum / k;
}
FindMaxAverage(nums, k);
*/
/*
int[] nums = [1, 12, -5, -6, 50, 3];

int k = 4;
int sum = 0;


for(int i =0; i< k; i++)
{
    sum += nums[i];
}

double maxSum = sum;

for(int i = k; i < nums.Length; i++)
{
    maxSum += nums[i] - nums[i - k];
    double result = Math.Max(maxSum, sum);
    Console.WriteLine(result / k);
}

*/
/*
int[] nums = [1, 12, -5, -6, 50, 3];

int k = 4;
int sum = 0;

for(int i = 0; i < k; i++)
{
    sum += nums[i];
}

double maxSum = sum;

for(int i = k; i < nums.Length; i++)
{
    sum = sum + nums[i] - nums[i - k];
    maxSum = Math.Max(maxSum, sum);
}

Console.WriteLine(maxSum/k);
    */
/*
int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
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
            k += 1 - nums[left];
            left++;
        }
    }
    Console.WriteLine(right - left);
    return right - left;
}

longestOnes(nums, k);
*/


/*
int[] nums = [1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0];
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

longestOnes(nums, k);
*/


/*

int[] nums = [1, 2, 3, 4,5,6];


int[] RunningSum(int[] nums)
{
    int first = nums[0];
    int total = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == first)
        {
            nums[i] = nums[i];
        }
        else
        {
            int temp = nums[i];
            nums[i] = total + temp;
            total = nums[i];
        }
        
    }
    return nums;
}






int[] nums = { 1, 2, 3, 4, 5, 6 };

int total = 0;

for (int i = 0; i < nums.Length; i++)
{
    total += nums[i];
    Console.WriteLine(total);
}

*/

/*
int[] nums = [-3, 2, -3, 4, 2];
            
int MinStartValue(int[] nums)
{
    for(int i = 1; i< nums.Length; i++)
    {
        nums[i] += nums[i - 1];
    }

    Array.Sort(nums);

    if (nums[0] >= 1)
    {
        return 1;
    }
    
    return Math.Abs(nums[0]) + 1;
    
}


int minStartValueWithPrefixSum(int[] nums)
{
    int sum = 0; int min_prefSum = 0;
    foreach(int i in nums)
    {
        sum += i;
        min_prefSum = Math.Min(min_prefSum, sum);
    }

    Console.WriteLine(1 - min_prefSum);
    return 1 - min_prefSum;
}

minStartValueWithPrefixSum(nums);
*/

/*
 * If there are less than k elements before or after the index i, then the k-radius average is -1.
 
 */
//i    //  0  1  2  3  4  5  6  7  8
/*
//K Radius Subarray Averages
int[] nums = [7, 4, 3, 9, 1, 8, 5, 2, 6]; int k = 3;
int[] resultArray = new int[nums.Length];
for (int i = 0; i < nums.Length; i++)
{
    if (i < k || i + k >= nums.Length)
    {
        resultArray[i] = -1;
    }
    else
    {
        resultArray[i] = 0;
    }
       // Console.WriteLine(resultArray[i].ToString(), ",");
    
}
*/

// int[] nums = [7, 4, 3, 9, 1, 8, 5, 2, 6]; int k = 3;
//         -1 -1 -1 






/*

int beforeTotal = 0;
int afterTotal = 0;
int first = 0;

   for(int i = 3; i < nums.Length -k; i++)
{
    while (first <= k)
    {
        beforeTotal += nums[k];
        k--;
    }

    k = i;
    
    while(i < nums.Length - k)
    {   
        afterTotal += nums[k + 1];
        k++;
    }
  
    k = 3;
    resultArray[i] = (beforeTotal + afterTotal) / (1+ (2 * k) );
    beforeTotal = 0;
    afterTotal = 0;
    first++;
    k++;
    

}

   for(int i = 0; i < nums.Length ; i++)
{
    Console.WriteLine(resultArray[i].ToString(), ",");
}
*/
/*
List<(int, int)> pairsList = new List<(int, int)> { (1, 2), (3, 2), (2, 4) };

List<(int, int)> result;
for(int i = 0; i < pairsList.Count; i++)
{
     result = pairsList[i,i +1];
}

*/

/*
int[] arr = [3, 1, 2, 6, 5, 4, 6];
int totalRepeated = 0;
int total = 0;
int pre_fix = 0;
int repeated = 0;
Array.Sort(arr);
for(int i = 1; i < arr.Length; i++)
{
    if (arr[i] == arr[i -1])
    {
        repeated = arr[i];
        
    }
    totalRepeated += arr[i];
}

for(int i = 0; i < arr.Length; i++)
{
    total += arr[i];
}

int result = total - totalRepeated;
Console.Write("Missing Number is " + (repeated + result));
Console.WriteLine(" Total Repeated " + repeated);
*/
//[1,3,2,4,1]
/*
int[] a = [0, 1, 2, 3, 4, 5, 6];
int missing = 0;
int total = 0;
for(int i = 0;i < a.Length; i++)
{
    if (a[i] != i)
    {
        missing += a[i];
       
    }
}
Console.WriteLine(missing);
Console.WriteLine(missing - 1);


[1,1,2,3,4,5,6] =22 / 7 3

[1,2,3,4,5,6,7] = 28 / 4

//M - R + 1 = missingvalue;
*/
/*
int total1 = 0;

int total2 = 0;
int[] arrr = [1, 1, 2, 3, 4, 5, 6];
for(int i = 0; i < arrr.Length; i++)
{
    total1 += arrr[i];
}

for (int i = 0; i < arrr.Length; i++)
{
    total2 += arrr[i];
}
int dtotal1 = total1 / arrr.Length;
int dtotal2 = total2 / arrr.Length; //L4 L3

Console.WriteLine(dtotal1 + dtotal2);
Console.WriteLine(dtotal1 - dtotal2);

int left = 0;
int right = s.Length - 1;
/*
if (1 <= s.Length && s.Length <= Math.Pow(10, 5))
{
    while (left < right)
    {
        char tmp = s[left];
        s[left++] = s[right];
        s[right--] = tmp;
    }
}
*/
/*
char[] arr = ['h', 'e', 'l', 'l', 'o'];
char[] result = new char[resultArray.Length];
int j = 0;
    for(int i = arr.Length - 1; i >= 0; i--)
{
     result[j] = arr[i];
    j++;
}
*/


/*
int[] TwoSum(int[] numbers, int target)
{
    int total = 0;
    int[] result = new int[2];
    if (numbers.Length < 2 && numbers.Length > (3 * Math.Pow(10, 4)))
    {
        throw new Exception("Invalid Length");
    }
    if (target < -1000 && target > 1000)
    {
        throw new Exception("Invalid Target");
    }
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < -1000 && numbers[i] > 1000)
        {
            throw new Exception("Invalid Index");
        }
        for (int j = 1 + i; j < numbers.Length; j++)
        {
            total += numbers[i] + numbers[j];
            if (total != target)
            {
                total = 0;
            }
            if (total == target)
            {
                if (i == 0)
                {
                    i = 1;
                    result[0] = i;
                    result[1] = j + 1;
                    break;



                }
                else if (i != 0)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    break;


                }



            }
       


        }

        if (total == target)
        {
            if(target == 0)
            {
                continue;
            }
            break;
        }

    }

    return result;
}


int[] nums = [-10, -8, -2, 1, 2, 5, 6];
int target = 0;
TwoSum(nums,target);
*/


/*
void Merge(int[] nums1, int m, int[] nums2, int n)
{
    /*
    1: Took  m element from nums1
    2: Took  n element from nums2
    2: Sort them:
    3: Remove 0
    
    if (nums1.Length != (m + n))
    {
        throw new Exception("Invalid Argument exception for m and n");
    };
    if (nums2.Length != n)
    {
        throw new Exception("Invalid Argument exception for n");
    };
    if ((m + n) < 1 && (m + n) > 200)
    {
        throw new Exception("Invalid Argument Exception");
    }

    int[] first = takeElementsFromFirstArray(nums1, m);
    int[] second = takeElementsFromSecondArray(nums2, n);

    int[] mergedArray = first.Concat(second).ToArray();
    Array.Sort(mergedArray);

    for (int i = 0; i < mergedArray.Length; i++)
    {
        nums1[i] = mergedArray[i];
    }

}

 int[] takeElementsFromFirstArray(int[] nums1, int m)
{
    int nonZeroCount = 0;

    for (int i = 0; i < nums1.Length; i++)
    {
        helperMethodForLoopConstraint(i);
        if (nums1[i] != 0)
        {
            nums1[nonZeroCount] = nums1[i];
            nonZeroCount++;
        }
    }

    Array.Resize(ref nums1, nonZeroCount);
    for (int i = 0; i < m; i++)
    {
        nums1[i] = nums1[i];
    }
    return nums1;
}
 int[] takeElementsFromSecondArray(int[] nums2, int n)
{
    int nonZeroCount = 0;
    for (int i = 0; i < n; i++)
    {
        helperMethodForLoopConstraint(i);
        if (nums2[i] != 0)
        {
            nums2[nonZeroCount] = nums2[i];
            nonZeroCount++;
        }
    }
    Array.Resize(ref nums2, nonZeroCount);
    for (int i = 0; i < n; i++)
    {
        nums2[i] = nums2[i];
    }

    return nums2;

}

 int helperMethodForLoopConstraint(int iterator)
{
    if (iterator < Math.Pow(-10, 9) && iterator > Math.Pow(10, 9))
    {
        throw new Exception("ındex out of bonds");
    }
    return iterator;
}




int[] nums1 = [-1, 0, 0, 3, 3, 3, 0, 0, 0];
int m = 6;
int[] nums2 = [1, 2, 2];
int n = 3;
Merge(nums1, m, nums2, n);

*/



int numRows = 4;



 IList<IList<int>> Generate(int numRows)
{
    /*
    if given number one return 1
    if given number two replicate 1
    write the first value of before list and sum it second elemend
    and and first value of before list*/

    if (numRows < 1 && numRows > 30)
    {
        throw new Exception("Invalid Argument Exception");
    }

    IList<IList<int>> res = new List<IList<int>>();

    if (numRows >= 1)
    {
        res.Add(new List<int>() { 1 });
    }

    if (numRows >= 2)
    {
        res.Add(new List<int>() { 1, 1 });
    }

    for (int i = 3; i <= numRows; i++)
    {
        IList<int> currentRow = new List<int>();
        IList<int> previousRow = res[i - 2];

        currentRow.Add(1);

        for (int j = 2; j <= i - 1; j++)
        {
            currentRow.Add(previousRow[j - 2] + previousRow[j - 1]);
        }

        currentRow.Add(1);

        res.Add(currentRow);
    }

    return res;
}

Generate(5);