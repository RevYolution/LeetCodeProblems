using System;
using Xunit;
using LeetCodeProblems.Easy;

namespace LeetCodeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReverseInt()
        {
            int test = 23456;
            IntegerReverse testReverse = new IntegerReverse();
            int testedInt = testReverse.Reverse(test);
            Assert.Equal(65432, testedInt);
        }

        [Theory]
        [InlineData(120, 21)]
        [InlineData(-123, -321)]
        [InlineData(2147483647, 0)]
        public void CanReverseIntTheory(int input, int expected)
        {
            IntegerReverse testReverse = new IntegerReverse();
            int tested = testReverse.Reverse(input);
            Assert.Equal(expected, tested);
        }

        [Theory]
        [InlineData(-121, false)]
        [InlineData(121, true)]
        public void IntegerPalindromTest(int input, bool expected)
        {
            IntegerPalindrom testPali = new IntegerPalindrom();
            bool tested = testPali.IsPalindrome(input);
            Assert.Equal(expected, tested);
        }

        //[Theory]
        //[InlineData()]
    }
}
