using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;

        private readonly int[] _array;
        private bool _wasElementFound;

        public BinarySearch(int[] array)
        {
            _array = array;
            Left = 0;
            Right = array.Length - 1;
            _wasElementFound = false;
        }

        public void Step(int N)
        {
            if(Left > Right)
                return;
            
            var mid = (Left + Right) / 2;

            if (N < _array[mid])
            {
                Right = mid - 1;
            }
            else if (N > _array[mid])
            {
                Left = mid + 1;
            }
            else
            {
                _wasElementFound = true;
            }
        }

        public int GetResult()
        {
            if (_wasElementFound)
                return 1;

            if (Left > Right)
                return -1;
            
            return 0;
        }
    }
}