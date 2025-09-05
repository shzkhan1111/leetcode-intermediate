using System;
using System.Data.Common;
using System.Runtime.ExceptionServices;

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
    public static int FibonacciMemoization(int capacity)
    {
        Dictionary<int, int> memo = new Dictionary<int, int>();
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
}

public class Program
{
    public static void Main()
    {
        //int[] weights = { 2, 3, 4 };
        //int[] values = { 3, 4, 5 };
        int capacity = 7;
        var ans = Solution.fibWithNoExtraSpace(capacity);



        Console.WriteLine(ans);

    }
}
