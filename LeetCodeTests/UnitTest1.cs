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
        //[InlineData(2147483647, 0)]
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
        [InlineData(new int[] { 1, 2, 5, 8, 5, 1, 5 }, 5)]
        public void MostFrequentTest(int[] input, int expected)
        {
            HighestOccurance testNew = new HighestOccurance();
            int tested = testNew.MostFrequent(input);
            Assert.Equal(expected, tested);
        }

        [Theory]
        [InlineData("I", null)]
        [InlineData("JO", null)]
        public void StringPlusTestIfStatement(string input, char[,] expected)
        {
            StringPlus testPlus = new StringPlus();
            char[,] tested = testPlus.MakeSign(input);
            Assert.Equal(expected, tested);
        }

        [Fact]
        public void StringPlusStringTest()
        {
            string input = "JON";
            char[,] expected = { { (char)0, 'J', (char)0 }, { 'J', 'O', 'N' }, { (char)0, 'N', (char)0 } };

            StringPlus testSign = new StringPlus();
            char[,] tested = testSign.MakeSign(input);
            Assert.Equal(expected, tested);
        }

        [Theory]
        [InlineData("Hello", "hello")]
        [InlineData("HELLO", "hello")]
        public void CanLowerString(string input, string expected)
        {
            ToLowerImp testLower = new ToLowerImp();
            string tested = testLower.ToLowerCase(input);
            Assert.Equal(expected, tested);
        }

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        public void CanFindSingle(int[] input, int expected)
        {
            FindSingleInt testSingle = new FindSingleInt();
            int tested = testSingle.SingleNumber(input);
            Assert.Equal(expected, tested);
        }
    }
}
