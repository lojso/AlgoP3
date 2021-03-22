using System;

namespace SortSpace
{
    public static class SortLevel
    {
        public static bool GallopingSearch(int[] array, int value)
        {
            var iteration = 1;
            var index = CalculateIndex(iteration);
            while (index < array.Length && array[index] < value)
            {
                if (array[index] == value)
                    return true;

                if (array[index] < value)
                {
                    iteration++;
                    index = CalculateIndex(iteration);
                }
            }

            index = Math.Min(CalculateIndex(iteration), array.Length - 1);

            var bsearch = new BinarySearch(array);
            bsearch.Left = Clamp(0, array.Length - 1,CalculateIndex(iteration - 1));
            bsearch.Right = index;

            while (bsearch.GetResult() == 0)
            {
                bsearch.Step(value);
            }

            if(bsearch.GetResult() == 1)
                return true;
            return false;
        }

        private static int Clamp(int min, int max, int value)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        private static int CalculateIndex(int i)
        {
            return (int) (Math.Pow(2, i) - 2);
        }

        private class BinarySearch
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
                else if (Right - Left < 1 )
                {
                    if(_array[Left] == val)
                    {
                        _searchStatus = 1;
                    }
                    else
                    {
                        _searchStatus = -1;
                    }
                }
            }

            public int GetResult()
            {
                return _searchStatus;
            }
        }
    }
}