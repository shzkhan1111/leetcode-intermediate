using Xunit;

public class SolutionTests
{
    [Fact]
    public void Test_TwoSum_Basic()
    {
        var sol = new Solution();
        int[] numbers = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = sol.TwoSum(numbers, target);

        Assert.Equal(new int[] { 1, 2 }, result); // 1-based index
    }

    [Fact]
    public void Test_TwoSum_OtherCase()
    {
        var sol = new Solution();
        int[] numbers = { 2, 3, 4 };
        int target = 6;
        int[] result = sol.TwoSum(numbers, target);

        Assert.Equal(new int[] { 1, 3 }, result);
    }

    [Fact]
    public void Test_TwoSum_Negatives()
    {
        var sol = new Solution();
        int[] numbers = { -1, 0 };
        int target = -1;
        int[] result = sol.TwoSum(numbers, target);

        Assert.Equal(new int[] { 1, 2 }, result);
    }
}
