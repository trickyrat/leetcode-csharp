// Licensed to the Trickyrat under one or more agreements.
// The Trickyrat licenses this file to you under the MIT license.

namespace LeetCode.Tests.SolutionTests;

public class ReadBinaryWatchUnitTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return
        [
            1, new[] { "0:01", "0:02", "0:04", "0:08", "0:16", "0:32", "1:00", "2:00", "4:00", "8:00" }
        ];
        yield return
        [
            9, Array.Empty<string>()
        ];
    }

    [Theory]
    [MemberData(nameof(GetData))]
    public void Test(int turnedOn, string[] expected)
    {
        var actual = Solution.ReadBinaryWatch(turnedOn);
        Assert.Equal(expected.ToList(), actual);
    }
}