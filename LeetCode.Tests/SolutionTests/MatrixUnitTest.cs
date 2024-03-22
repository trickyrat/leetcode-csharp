using System.Collections.Generic;
using Xunit;

namespace LeetCode.Tests.SolutionTests;

public class MatrixUnitTest
{
    public static IEnumerable<object[]> GetMatrix()
    {
        yield return
        [
            new[]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
            },
            new[]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 0, 0, 0 },
            }
        ];

        yield return
        [
            new[]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 1, 1 },
            },
            new[]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 2, 1 },
            }
        ];
    }
    
    [Theory]
    [MemberData(nameof(GetMatrix))]
    public void Test(int[][] matrix, int[][] expected)
    {
        var actual = Solution.UpdateMatrix(matrix);
        Assert.Equal(expected, actual);
    }
}