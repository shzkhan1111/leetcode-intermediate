using System;
using System.Data.Common;
using System.Runtime.ExceptionServices;

public class Solution
{
    public static int SolveKnapsack(int[] weights ,int[] values, int capacity)
    {
        int numberOfItems = weights.Length;
        //store the results 
        int[,] data = new int[numberOfItems  + 1, capacity + 1];
        for (int i = 1; i <= numberOfItems; i++)
        {
            for (int currweight = 0; currweight <= capacity; currweight++)
            {
                //i = 0 means 0 items allowed
                //currweight = 0 means no weight allowed in the bag so far
                if (i == 0 || currweight == 0)
                {
                    data[i, currweight] = 0;
                }
                //if weight of the item is greater then the current allowed weight we skip it and take the best value without that item 
                //for that weight 
                else if (weights[i - 1] >  currweight)
                {
                    //ignore the current 
                    data[i, currweight] = data[i - 1, currweight];
                }
                else
                {
                    //take current item and in the same row for the items take the weight of 
                    int TakeCurrentVal = values[i - 1] + data[i, currweight - weights[i - 1]];
                    //like before
                    int SkipCurrentVal = data[i - 1, currweight];
                    int maxWeight = Math.Max(TakeCurrentVal , SkipCurrentVal);
                    data[i, currweight] = maxWeight;
                }
            }
        }
        for (int i = 0; i < data.GetLength(0); i++)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                Console.Write($"   {data[i, j]}   ");
            }
            Console.WriteLine();
        }
        return data[numberOfItems, capacity];
    }
}

public class Program
{
    public static void Main()
    {
        int[] weights = { 2, 3, 4 };
        int[] values = { 3, 4, 5 };
        int capacity = 5;
        var ans = Solution.SolveKnapsack(weights, values, capacity);



        Console.WriteLine("Printed Grid");

    }
}
