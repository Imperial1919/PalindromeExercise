using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {


            //word arguement is converted to lowercase lettering
            var lower = word.ToLower();
            //word argument after lower letter conversion, is then converted again to a CharArray data type
            var chararray = word.ToCharArray();
            //This simply reverses forementioned array
            var test = chararray.Reverse();


            //This assigns the operation of testing for similarities between the fully converted test variable, and the basic low case lettered 'lower' variable
            bool IsPalindrome = lower.SequenceEqual(test);
            return IsPalindrome;
          

        }

    }
}
