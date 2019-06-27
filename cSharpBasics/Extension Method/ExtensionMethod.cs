using System;

namespace cSharpBasic
{
    static class ExtendedMethod
    {
        public static string FirstLetterToUpper(this string value)
        {
            string firstLetter = value.Substring(0,1).ToUpper();
            string remainingLetters = values.Substring(1,value.Length());
            return firstLetter+remainingLetters;
        }
    }
    class baseClass
    {
       static void Main(string[] args)
        {
            string word = "Hello";
            System.Console.WriteLine(word.FirstLetterToUpper());
        } 
    }
}