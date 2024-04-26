using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace BasicOfNETFrameworkAndCSharpWithUnitTests
{
    public class Message
    {
        public static int GetMaxConsecutiveDifferentCharacters(string s)
        {
            if (s != string.Empty)
            {
                int maxChar = 1,
                currentChar = 1;

                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] != s[i + 1])
                    {
                        currentChar++;
                    }
                    else
                    {
                        currentChar = 1;
                    }
                    if (currentChar > maxChar)
                    {
                        maxChar = currentChar;
                    }
                }
                return maxChar;
            }
            return 0;
        }

        public static int GetMaxConsecutiveLatinLetters(string s)
        {
            return Regex.Matches(s, "[A-Za-z]+")
                        .Cast<Match>()
                        .Select(m => m.Value.Length)
                        .DefaultIfEmpty(0)
                        .Max();
        }

        public static int GetMaxConsecutiveDigits(string s)
        {
            return Regex.Matches(s, "\\d+")
                        .Cast<Match>()
                        .Select(m => m.Value.Length)
                        .DefaultIfEmpty(0)
                        .Max();
        }
    }
}
