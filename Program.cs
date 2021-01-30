using System;
using SortSpace;

namespace AlgoP3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var arr = new[] {1,6,5,4,3};
            var arr2 = new[] {2, 1, 3};
            var arr3 = new[] {87, 17, 24, 61, 71, 78, 72, 30, 2, 35, 64, 38, 86};
            var arr4 = new[] {87, 17};
            var arr5 = new[] {87};

            var res = SortLevel.KnuthSequence(1);
            SortLevel.ShellSort(arr5);

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}