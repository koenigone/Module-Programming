using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringInfoClass
{
    internal class StringInfoClass
    {
        private string word;

        public void SetString(string s)
        {
            word = s;
        }
        public int GetUppercaseCount()
        {
            int count = 0;
            foreach (char c in word)
            {
                if (char.IsUpper(c))
                {
                    count++;
                }
            }
            return count;
        }
        public int GetLowercaseCount()
        {
            int count = 0;
            foreach (char c in word)
            {
                if (char.IsLower(c))
                {
                    count++;
                }
            }
            return count;
        }
        public bool ContainsSpace()
        {
            bool condition = false;
            foreach (char c in word)
            {
                if (char.IsWhiteSpace(c))
                {
                    condition = true;
                }
            }
            return condition;
        }
        public bool ContainsSymbol()
        {
            bool condition = false;
            foreach (char c in word)
            {
                if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    condition = true;
                }
            }
            return condition;
        }
        public bool HasAtLeast(int n, char c)
        {
            int count = 0;
            foreach (char ch in word)
            {
                if (ch == c)
                {
                    count++;
                }
                if (count >= n)
                {
                    return true;
                }
            }
            return count >= n;
        }
    }
}
