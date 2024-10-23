using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StringProcessing
{
    internal class StringWrapper
    {
        private string Sentence { get; }

        public int Length 
        {
            get
            {
                int index = 0;
                foreach (char c in Sentence)
                {
                    index++;
                }
                return index;   
            } 
        }

        public StringWrapper(string sentence)
        {
            Sentence = sentence;
        }

        public string MySubstring(int StartIndex, int SubLength)
        {
            if(StartIndex < 0 )
            {
                throw new ArgumentOutOfRangeException("The starting index can not be less than zero");
            }
            if (StartIndex > Length)
            {
                throw new ArgumentOutOfRangeException("The starting index can not be more than length");
            }
            if (SubLength > Length)
            {
                throw new IndexOutOfRangeException("The sublength cannot be more than length");
            }
            if (SubLength < 0)
            {
                throw new IndexOutOfRangeException("The sublength can not be less than zero");
            }
            string newStr = "";
            for(int i = StartIndex; i < SubLength + StartIndex; i++)
            {
                newStr += Sentence[i];
            }
            return newStr;
        }

        public string MySubstring(int SubLength)
        {
            if (SubLength > Length)
            {
                throw new IndexOutOfRangeException("The sublength cannot be more than length");
            }
            if (SubLength < 0)
            {
                throw new IndexOutOfRangeException("The sublength can not be less than zero");
            }
            string newStr = "";
            for (int i = Length - 1; i >= SubLength; i--)
            {
                newStr = Sentence[i] + newStr;
            }
            return newStr;
        }

        public int MyIndexOf(char c)
        {
            for(int i = 0; i < Length; i++)
            {
                if(Sentence[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MyIndexOf(string str)
        {
            int flag = str.Length;
            for (int i = 0; i <= Sentence.Length - flag; i++)
            {
                if (Sentence.Substring(i, flag) == str)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MyLastIndexOf(char c)
        {
            for(int i = Length - 1; i > 0; i --)
            {
                if (Sentence[i] == c)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MyLastIndexOf(string str)
        {
            int flag = str.Length;
            for(int i = Length - flag; i >= 0; i--)
            {
                if (Sentence.Substring(i, flag) == str)
                {
                    return i;
                }
            }
            return -1;
        }

        public string MyToUpper()
        {
            string str = "";
            for (int i = 0;i < Length;i++)
            {
                char c = Sentence[i];
                if(c >= 'a' && c <= 'z')
                {
                    c = (char)(c - 32);
                } 
                str += c;
            }
            return str;
        }

        public string MyToLower()
        {
            string str = "";
            for (int i = 0; i < Length; i++)
            {
                char c = Sentence[i];
                if (c >= 'A' && c <= 'Z')
                {
                    c = (char)(c + 32);
                }
                str += c;
            }
            return str;
        }
    }
}
