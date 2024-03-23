namespace LeetCode.Tests.SolutionTests;

public class PrintOrderUnitTest
{
    public static TheoryData<List<int>, string> Data =>
        new()
        {
            { [1, 2, 3], "firstsecondthird"},
            { [1, 3, 2], "firstsecondthird"},
            { [2, 1, 3], "firstsecondthird"},
            { [2, 3, 1], "firstsecondthird"},
            { [3, 1, 2], "firstsecondthird"},
            { [3, 2, 1], "firstsecondthird"}
        };
    
    
    [Theory]
    [MemberData(nameof(Data))]
    public async Task Test(List<int> sequences, string expected)
    {
        string actual = "";
        // Given
        var foo = new Foo();
        List<Task> tasks = [];
        tasks.AddRange(sequences.Select(sequence => Task.Run(() =>
        {
            switch (sequence)
            {
                case 1:
                    foo.First(PrintFirst);
                    break;
                case 2:
                    foo.Second(PrintSecond);
                    break;
                default:
                    foo.Third(PrintThird);
                    break;
            }
        })));

        await Task.WhenAll(tasks);
        // When
        Assert.Equal(expected, actual);
        return;
        // Then

        void PrintFirst()
        {
            actual += "first";
        }
        void PrintSecond()
        {
            actual += "second";
        }
        void PrintThird()
        {
            actual += "third";
        }
    }
}