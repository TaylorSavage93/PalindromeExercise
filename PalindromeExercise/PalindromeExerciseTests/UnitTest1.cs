using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mom", true)]
        [InlineData("Friend", false)]
        [InlineData("dad", true)]
        public void MyTest(string word, bool expected)
        {
            
            {
                //arrange
                var test = new WordSmith();
                //act
                var actual = test.IsAPalindrome(word);
                //assert
                Assert.Equal(expected, actual);
            }
        }
    }
}
