using System;
using Xunit;
using PalindromeExercise;
//never forget the tiny little, 'using' attributes. :)

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("anna",true)]
        public void WordSmith(string word, bool conditional)
        {
            // Arrangement Phase:
            var arrange = new WordSmith();

            //Action Phase:
            var actual = arrange.IsAPalindrome(word);

            //Assert Phase:
            Assert.Equal(actual,conditional);

          

        }
    }
}
