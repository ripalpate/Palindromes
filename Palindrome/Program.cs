using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Phrase");
            var Phrase= Console.ReadLine().ToLower();
            var ReversePhrase = "";
            string RemoveSpaceAndPunctuationString = Regex.Replace(Phrase, @"(?i)[^a-z]", "");
            for (var i = RemoveSpaceAndPunctuationString.Length -1; i >= 0; i--)
            {
                ReversePhrase += RemoveSpaceAndPunctuationString[i].ToString();
            }
            if (ReversePhrase == RemoveSpaceAndPunctuationString)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }     

    }
}
