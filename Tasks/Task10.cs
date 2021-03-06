using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class ksort
    {
        public string[] items;
        private char[] _allowedChars = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'};
        
        public ksort()
        {
            items = new string[799];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = null;
            }
        }

        public int index(string s)
        {
            return GetCharNum(s);
        }

        public bool add(string s)
        {
            var num = StringToNum(s);
            if(num == -1)
                return false;
            items[num] = s;
            return true;
        }


        private int StringToNum(string s)
        {
            if (s.Length != 3)
                return -1;
            
            var charNum = GetCharNum(s);
            if (charNum == -1)
                return -1;

            int mn;
            if (int.TryParse(s.Substring(1), out mn))
                return charNum * 100 + mn;

            return -1;
        }

        private int GetCharNum(string s)
        {
            return LinearSearch(_allowedChars, s[0]);
        }

        private int LinearSearch(char[] array, char ch)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == ch)
                    return i;
            }

            return -1;
        }
    }
}