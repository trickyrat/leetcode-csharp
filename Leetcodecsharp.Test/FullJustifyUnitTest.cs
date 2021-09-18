using System.Collections.Generic;

using Xunit;

namespace Leetcodecsharp.Test
{
    public class FullJustifyUnitTest
    {
        [Fact]
        public void FullJustifyTest1()
        {
            string[] words = { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
            IList<string> expected = new List<string> { "Science  is  what we",
                                                        "understand      well",
                                                        "enough to explain to",
                                                        "a  computer.  Art is",
                                                        "everything  else  we",
                                                        "do                  "};
            int maxWidth = 20;
            IList<string> actual = Solution.FullJustify(words, maxWidth);
            Assert.Equal(expected, actual);
        }
    }
}
