using Leetcodecsharp;
using Xunit;

namespace Leetcodecsharp.Test
{
    public class RemoveDuplicatesFromSortedArrayIIUnitTest
    {
        public Solution Solution { get; set; }
        public RemoveDuplicatesFromSortedArrayIIUnitTest()
        {
            Solution = new Solution();
        }

        [Fact]
        public void Test1()
        {
            var nums = new int[] { 1, 1, 1, 2, 2, 3 };
            var expected = 5;
            var actual = Solution.RemoveDuplicatesV2(nums);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            var expected = 7;
            var actual = Solution.RemoveDuplicatesV2(nums);
            Assert.Equal(expected, actual);
        }
    }
}
