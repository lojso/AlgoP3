using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class Task4
    {
        public static int ArrayChunk(int[] M)
        {
            while (true)
            {
                var NIndex = M.Length / 2;
                var N = M[NIndex];
                var i1 = 0;
                var i2 = M.Length - 1;
                while (true)
                {
                    while (M[i1] < N)
                    {
                        i1++;
                    }

                    while (M[i2] > N)
                    {
                        i2--;
                    }

                    if (i1 == i2 - 1 && M[i1] > M[i2])
                    {
                        Swap(M, i1, i2);
                        break;
                    }

                    if (i1 == i2 || (i1 == i2 - 1 && M[i1] < M[i2]))
                    {
                        return NIndex;
                    }

                    Swap(M, i1, i2);
                    
                    if (M[i1] == N)
                    {
                        NIndex = i1;
                    }
                    
                    if (M[i2] == N)
                    {
                        NIndex = i2;
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