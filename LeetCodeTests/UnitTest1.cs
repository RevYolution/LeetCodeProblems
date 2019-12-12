using System;
using Xunit;
using LeetCodeProblems.Easy;
using LeetCodeProblems.Interview;

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

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] {1,2,5,8,5,1,5}, 5)]
        public void MostFrequentTest(int[] input, int expected)
        {
            HighestOccurance testNew = new HighestOccurance();
            int tested = testNew.MostFrequent(input);
            Assert.Equal(expected, tested);
        }
    }
}
