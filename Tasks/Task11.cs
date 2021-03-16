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
            _searchStatus = (Left > Right) ? -1 : 0;
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

            CheckSearchFinish(N);
        }

        private void CheckSearchFinish(int val)
        {
            if(_searchStatus != 0)
                return;
            
            if (Left > Right)
            {
                _searchStatus = -1;
            }
            else if (Right - Left <= 1 && _array[Left] == val)
            {
                _searchStatus = 1;
            }
        }

        public int GetResult()
        {
            return _searchStatus;
        }
    }
}