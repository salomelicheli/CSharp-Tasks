using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessing
{
    public static class StringExtensions
    {
        public static string[] MySplit(this string s, char Flag = ' ')
        {
            int mark = 0;
            int length = s.Length;
            int newArrayLength = 1;
            for (int i = 0; i < length; i++)
            {
                if (s[i] == Flag)
                {
                    newArrayLength++;
                }
            }
            string[] newArray = new string[newArrayLength];
            int k = 0;
            for (int i = 0; i < length; i++)
            {
                if(s[i] == Flag)
                {
                    newArray[k] = s.Substring(mark, i - mark);
                    mark = i + 1;
                    k++;
                }
            }
            newArray[k] = s.Substring(mark, length - mark);

            return newArray;
        }

        public static bool MyContains(this string s, string word)
        {
            if (word == null)
            {
                throw new ArgumentNullException("The given word was null");
            }
                
            for (int i = 0; i < s.Length - word.Length; i++)
            {
                if (s.Substring(i, word.Length) == word)
                {
                    return true;
                }
            }
            return false;
        }

        public static string MyJoin(string[] s, string separator)
        {
            string NewString = "";
            for (int i = 0; i < s.Length; i++)
            {
                NewString += s[i];
                if (i != s.Length - 1)
                {
                    NewString += separator;
                }
            }
            return NewString;
        }

        public static bool MyStartsWith(this string s, string word)
        {
            if(word.Length > s.Length)
            {
                return false;
            }
            bool StartsWith = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (s[i] != word[i])
                {
                    StartsWith = false;
                    break;
                }
            }
            return StartsWith;
        }

        public static bool MyEndsWith(this string s, string word)
        {
            if (word.Length > s.Length)
            {
                return false;
            }
            bool EndsWith = true; 
            int k = word.Length - 1; 

            for (int i = s.Length - 1; i > s.Length - word.Length - 1; i--)
            {
                if (s[i] != word[k])
                {
                    EndsWith = false;
                    break;
                }
                k--;
            }
            return EndsWith;
        }
    }
}
