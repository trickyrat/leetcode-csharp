using Leetcode;
using Xunit;

namespace Leetcodecsharp.Test
{

    public class ValidIPAdressUnitTest
    {
        [Fact]
        public void IPv4Test()
        {
            string address = "172.16.254.1";
            string expected = "IPv4";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IPv6Test()
        {
            string address = "2001:0db8:85a3:0:0:8A2E:0370:7334";
            string expected = "IPv6";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv4Test1()
        {
            string address = "256.256.256.256";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv4Test2()
        {
            string address = "056.256.256.256";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv4Test3()
        {
            string address = "0.016.056.056";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv4Test4()
        {
            string address ="12.12.12.12.12";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv4Test5()
        {
            string address = "12.12..12.12";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv6Test1()
        {
            string address = "0az:12:12:12:12:123:23:32";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void InvalidIPv6Test2()
        {
            string address = "0az:12:12:12:12:123";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv6Test3()
        {
            string address = "0a:12:12:12::123:23:0A";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InvalidIPv6Test4()
        {
            string address = "0a:12:12:12:12:123:23:32:11";
            string expected = "Neither";
            string actual = Solution.ValidIPAddress(address);
            Assert.Equal(expected, actual);
        }

    }
}
