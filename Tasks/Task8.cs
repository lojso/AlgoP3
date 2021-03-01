using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class Task8
    {
        public static List<int> MergeSort(List<int> array)
        {
            var arr = array.ToArray();
            MergeSort(arr, 0, array.Count - 1);
            return ArrayToList(arr);
        }

        private static List<int> ArrayToList(int[] arr)
        {
            var l = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                l.Add(arr[i]);
            }

            return l;
        }

        private static void MergeSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;
            var middle = (left + right) / 2;
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            Merge(array, left, middle, right);
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            var leftArray = new int[middle - left + 1];
            var rightArray = new int[right - middle];

            CopyArray(array, leftArray, left);
            CopyArray(array, rightArray, middle + 1);
            
            int leftIndex = 0;
            int rightIndex = 0;

            int arrayIndex = left;
            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[arrayIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[arrayIndex] = rightArray[rightIndex];
                    rightIndex++;
                }

                arrayIndex++;
            }

            while (leftIndex < leftArray.Length)
            {
                array[arrayIndex] = leftArray[leftIndex];
                arrayIndex++;
                leftIndex++;
            }
            
            while (rightIndex < rightArray.Length)
            {
                array[arrayIndex] = rightArray[rightIndex];
                arrayIndex++;
                rightIndex++;
            }
        }

        private static void CopyArray(int[] source, int[] destination, int startIndex)
        {
            for (int i = 0; i < destination.Length; i++)
            {
                destination[i] = source[startIndex + i];
            }
        }
    }
}