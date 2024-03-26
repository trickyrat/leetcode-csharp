namespace LeetCode.Tests.SolutionTests;

public class GraphUnitTest
{
    [Fact]
    public void Test()
    {
        var graph = new Graph(4, [[0, 2, 5], [0, 1, 2], [1, 2, 1], [3, 0, 3]]);
        Assert.Equal(6, graph.ShortestPath(3, 2));
        Assert.Equal(-1, graph.ShortestPath(0, 3));
        graph.AddEdge([1, 3, 4]);
        Assert.Equal(6, graph.ShortestPath(0, 3));
    }
}
