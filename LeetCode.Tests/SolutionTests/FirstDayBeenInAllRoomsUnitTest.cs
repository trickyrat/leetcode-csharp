namespace LeetCode.Tests.SolutionTests;

public class FirstDayBeenInAllRoomsUnitTest
{
    public static TheoryData<int[], int> Data =>
        new()
        {
            { [0, 0], 2 },
            { [0, 0, 2], 6 },
            { [0, 1, 2, 0], 6 },
        };

    [Theory]
    [MemberData(nameof(Data))]
    public void Test(int[] nextVisit, int expected)
    {
        var actual = Solution.FirstDayBeenInAllRooms(nextVisit);
        Assert.Equal(expected, actual);
    }
}