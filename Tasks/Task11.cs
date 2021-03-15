using System;
using System.Collections.Generic;

namespace SortSpace
{
    public class BinarySearch
    {
        public int Left;
        public int Right;

        private readonly int[] _array;
        private int _searchStatus;

        public BinarySearch(int[] array)
        {
            _array = array;
            Left = 0;
            Right = array.Length - 1;
            _searchStatus = 0;
            
            CheckSearchFinish();
        }

        public void Step(int N)
        {
            if(_searchStatus != 0)
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
                _searchStatus = 1;
            }

            CheckSearchFinish();
        }

        private void CheckSearchFinish()
        {
            if (_searchStatus == 0 && Left > Right)
            {
                _searchStatus = -1;
            }
        }

        public int GetResult()
        {
            return _searchStatus;
        }
    }
}