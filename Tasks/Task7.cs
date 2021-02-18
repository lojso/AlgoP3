using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static List<int> KthOrderStatisticsStep( int[] Array, int L, int R, int k )
        {
            var result = new List<int>();

            var pivot = ArrayChunk(Array, L, R);

            if (pivot > k)
            {
                return KthOrderStatisticsStep(Array, L, pivot - 1, k);
            }

            if (pivot < k)
            {
                return KthOrderStatisticsStep(Array, pivot + 1, R, k);
            }
            
            result.Add(L);
            result.Add(R);
            result.Add(Array[pivot]);
            return result;
        }
        
        
        public static int ArrayChunk(int[] M, int start, int end)
        {
            while (true)
            {
                var NIndex = (start + end + 1) / 2;
                var N = M[NIndex];
                var i = start;
                var j = end;
                while (true)
                {
                    while (M[i] < N)
                    {
                        i++;
                    }

                    while (M[j] > N)
                    {
                        j--;
                    }

                    if (i == j - 1 && M[i] > M[j])
                    {
                        Swap(M, i, j);
                        break;
                    }

                    if (i == j || (i == j - 1 && M[i] < M[j]))
                    {
                        return NIndex;
                    }

                    Swap(M, i, j);

                    if (M[i] == N)
                    {
                        NIndex = i;
                    }

                    if (M[j] == N)
                    {
                        NIndex = j;
                    }
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}