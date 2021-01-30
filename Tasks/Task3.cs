using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static List<int> KnuthSequence( int array_size )
        {
            var seq = new List<int>();
            for (int i = 1; i <= array_size; i = NextElement(i))
            {
                seq.Add(i);
            }

            seq.Reverse();
            return seq;
        }

        public static int NextElement(int currentElement)
        {
            return 3 * currentElement + 1;
        }
    }
}