using System;
using System.Data.Common;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

public class Solution
{
    //public static int LongestCommonSubsequence(string X, string Y)
    //{
    //    int lengstr1 = X.Length;
    //    int lengstr2 = Y.Length;
    //    int[,] subsequentList = new int[lengstr1 + 1, lengstr2 + 1];
    //    for (int i = 1; i <= lengstr1; i++)
    //    {
    //        for (int j = 1; j <= lengstr2; j++)
    //        {
    //            if (X[i- 1] == Y[j -1])
    //            {

    //            }
    //        }
    //    }
    //}
}

public class Program
{
    public static string organizingContainers(List<List<int>> container)
    {
        //logic count the total count in the container 
        //get the total count per type of balls 
        //sort and check if there is a ball for each conatiner 
        //get the sum per container 
        int count = container.Count;
        List<int> containerSum = new List<int>();
        List<int> typeSum = new List<int>();
        for (int i = 0; i < count; i++)
        {
            int sum = 0;
            for (int j = 0; j < count; j++)
            {
                sum += container[i][j];
            }
            containerSum.Add(sum);
        }
        for (int i = 0; i < count; i++)
        {
            int sum = 0;
            for (int j = 0; j < count; j++)
            {
                sum += container[j][i];
            }
            typeSum.Add(sum);
        }
        containerSum.Sort();
        typeSum.Sort();
        for (int i= 0; i < count; i++)
        {
            if (containerSum[i] != typeSum[i])
            {
                return "Impossible";
            }
        }
        return "Possible";
    }

    static string OrganizingContainers(List<List<int>> container)
    {
        return "";
    }
    public static void Main()
    {
        var containers = new List<List<int>> {
            new List<int> {0,2},
            new List<int> {1, 1}
            //new List<int> {2, 1 ,1},

        };
        var s = organizingContainers(containers);
    }
}
