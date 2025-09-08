using System;
using System.Data.Common;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

public class Solution
{
    public static int FibRecursion(int capacity)
    {
        //Fibonacci
        //nth item is the sum of n - 1 and n - 2 item
        //0 1 1 2 3 5 8 13
        if (capacity <= 1)
        {
            return capacity;
        }
        return FibRecursion(capacity - 2) + FibRecursion(capacity - 1);
    }
    private static Dictionary<int, int> memo = new Dictionary<int, int>();
    public static int FibonacciMemoization(int capacity)
    {
        
        if (capacity <= 1)
        {
            return capacity;
        }
        //check if the number has already been visited 
        if (memo.ContainsKey(capacity))
        {
            return memo[capacity];
        }
        memo[capacity] = FibonacciMemoization(capacity - 2) + FibonacciMemoization(capacity - 1);
        return memo[capacity];
    }
    //other appraoches using loop
    public static int fibloop1(int n)
    {
        //top down approach
        int[] output = new int[n + 1];
        output[0] = 0;
        output[1] = 1;

        for (int i = 2; i <= 7; i++)
        {
            output[i] = output[i - 1] + output[i - 2];
        }
        return output[n];
    }
    public static int fibWithNoExtraSpace(int n)
    {
        //0 1 1 2 3 5 8 13
        int a = 0;
        int b = 1;
        for (int i = 2; i <= n; i++)
        {
            int current = a + b;
            a = b;
            b = current;

        }
        return b;
    }
    //int ClimbStairsRecursive(int n)
    //{
    //    if (n <= 2) return n; // base cases
    //    return ClimbStairsRecursive(n - 1) + ClimbStairsRecursive(n - 2);
    //}
    public static int ClimbingStairsRecursion(int n)
    {
        if (n <= 2)
        {
            return n;
        }
        return ClimbingStairsRecursion(n - 1) + ClimbingStairsRecursion(n - 2);
    }
    private static Dictionary<int, int> NumbersToWaysMapping = new Dictionary<int, int>();
    public static int ClimbingStairsMemoizedRecursion(int n)
    {
        //number key 
        //number of ways to that place value
       
        if (n <= 2)
        {
            return n;
        }
        //I have seen this value 
        if (NumbersToWaysMapping.ContainsKey(n))
        {
            return NumbersToWaysMapping[n];
        }
        //since the same values is being calculated again and again 
        // if I have seen the value memoize it
        NumbersToWaysMapping[n] = ClimbingStairsMemoizedRecursion(n - 2) + ClimbingStairsMemoizedRecursion(n - 1);
        //and return it
        return NumbersToWaysMapping[n];

    }
    public static int ClimbingStairsWithExtraSpace(int n)
    {
        if (n <= 2)
        {
            return n;
        }
        int[] data = new int[n];
        data[0] = 1;
        data[1] = 2;

        for (int i = 2; i < n; i++)
        {
            data[i] = data[i - 1] + data[i - 2];
        }
        return data[n - 1];
    }
    public static int ClimbingStairsNoExtraSpace(int n)
    {
        int first = 1, second = 2;
        if (n <= 2)
        {
            return n;
        }
        for (int i = 2; i < n; i++)
        {
            int current = first + second;
            first = second;
            second = current;
        }
        return second;
    }
}

public class Program
{
    public static void Main()
    {
        //int[] weights = { 2, 3, 4 };
        //int[] values = { 3, 4, 5 };
        int capacity = 5;
        var ans = Solution.ClimbingStairsRecursion(capacity);
        var ans1 = Solution.ClimbingStairsNoExtraSpace(capacity);
        var ans2 = Solution.ClimbingStairsWithExtraSpace(capacity);
        var ans3 = Solution.ClimbingStairsMemoizedRecursion(capacity);



        Console.WriteLine(ans);

    }
}
