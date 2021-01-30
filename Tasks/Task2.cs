using System;
using System.Collections.Generic;

namespace SortSpace
{
    public static class SortLevel
    {
        public static void InsertionSortStep(int[] array, int step, int i)
        {
            var stepArray = new int[(int)Math.Ceiling((float)(array.Length - i) / step)];
            for (int j = i, k = 0; j < array.Length; j+= step, k++)
            {
                stepArray[k] = array[j];
            }
            
            SimpleInsertionStep(stepArray);
            
            for (int j = i, k = 0; j < array.Length; j+= step, k++)
            {
                array[j] = stepArray[k];
            }
        }

        public static void SimpleInsertionStep(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var positionToInsertion = FindPositionToInsert(array, i);
                InsertElement(array, positionToInsertion, i);
            }
        }

        private static int FindPositionToInsert(int[] array, int index)
        {
            var result = index;
            for (int i = index - 1; i >= 0; i--)
            {
                if (array[i] < array[index])
                    return i + 1;
                result = i;
            }
            return result;
        }

        private static void InsertElement(int[] array, int insertionIndex, int elementIndex)
        {
            if (insertionIndex < elementIndex)
            {
                InsertLeft(array, insertionIndex, elementIndex);
            }
            else if (insertionIndex > elementIndex)
            {
                InsertRight(array, insertionIndex, elementIndex);
            }
        }

        private static void InsertRight(int[] array, int insertionIndex, int elementIndex)
        {
            var element = array[elementIndex];
            
            for (int i = elementIndex + 1; i <= insertionIndex; i++)
            {
                array[i] = array[i + 1];
            }

            array[insertionIndex] = element;
        }

        private static void InsertLeft(int[] array, int insertionIndex, int elementIndex)
        {
            var element = array[elementIndex];
            
            for (int i = elementIndex; i > insertionIndex; i--)
            {
                array[i] = array[i - 1];
            }

            array[insertionIndex] = element;
        }
        
        private static void Swap(int[] array, int i, int minElementIndex)
        {
            var temp = array[i];
            array[i] = array[minElementIndex];
            array[minElementIndex] = temp;
        }
    }
}