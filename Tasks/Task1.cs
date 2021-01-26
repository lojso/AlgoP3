using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void SelectionSortStep(int[] array, int i)
        {
            if (i >= array.Length - 1)
            {
                return;
            }

            var minElementIndex = FindMinElementIndex(array, i + 1);
            if (array[i] > array[minElementIndex])
                Swap(array, i, minElementIndex);
        }

        private static int FindMinElementIndex(int[] array, int startIndex)
        {
            var currentMinIndex = startIndex;
            for (int i = startIndex + 1 ; i < array.Length; i++)
            {
                if (array[i] < array[currentMinIndex])
                {
                    currentMinIndex = i;
                }
            }

            return currentMinIndex;
        }

        private static void Swap(int[] array, int i, int minElementIndex)
        {
            var temp = array[i];
            array[i] = array[minElementIndex];
            array[minElementIndex] = temp;
        }
        
        //++++++++++++++++++++++

        public static bool BubbleSortStep(int[] array)
        {
            var isSorted = true;
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(array, i, i + 1);
                    isSorted = false;
                }
            }
            
            return isSorted;
        }
    }
}