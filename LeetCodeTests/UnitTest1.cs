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
    }
}
