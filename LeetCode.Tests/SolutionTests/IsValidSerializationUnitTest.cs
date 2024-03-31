namespace LeetCode.Tests.SolutionTests;

public class IsValidSerializationUnitTest
{
    public static TheoryData<string, bool> Data =>
        new()
        {
            { "9,3,4,#,#,1,#,#,2,#,6,#,#", true },
            { "1,#", false },
            { "9,#,#,1", false },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(string preorder, bool expected)
    {
        var actual = Solution.IsValidSerialization(preorder);
        Assert.Equal(expected, actual);
    }
}