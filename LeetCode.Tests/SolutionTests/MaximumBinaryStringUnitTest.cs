namespace LeetCode.Tests.SolutionTests;

public class MaximumBinaryStringUnitTest
{
    public static TheoryData<string, string> Data =>
        new()
        {
            { "000110", "111011" },
            { "01", "01" },
            { "11", "11" },
            { "1000", "1110" },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(string binary, string expected)
    {
        var actual = Solution.MaximumBinaryString(binary);
        Assert.Equal(expected, actual);
    }
}
