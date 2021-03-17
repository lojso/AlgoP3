using NUnit.Framework;
using SortSpace;

namespace Test
{
    [TestFixture]
    public class Task11
    {
        [Test]
        public void Array_123_Search2()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(2);
            
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 2);
        }
        
        [Test]
        public void Array_123_Search2_Oversearch()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(2);
            bsearch.Step(2);
            bsearch.Step(2);

            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 2);
        }
        
        [Test]
        public void Array_123_Search1()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(1);

            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 0);
        }
        
        [Test]
        public void Array_123_Search3()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(3);
            
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 2);
            Assert.True(bsearch.Right == 2);
        }

        [Test]
        public void Array_123_Search4()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(4);
            
            Assert.True(bsearch.GetResult() == -1);
            Assert.True(bsearch.Left == 2);
            Assert.True(bsearch.Right == 2);
            
        }

        [Test]
        public void Array_123_Search0()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(0);
            
            Assert.True(bsearch.GetResult() == -1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 0);
            
        }
        
        [Test]
        public void Array_1_Search1()
        {
            var bsearch = new BinarySearch(new int[]{1});
             
            bsearch.Step(1);
            
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 0);
        }
        
        [Test]
        public void Array_1_Search0()
        {
            var bsearch = new BinarySearch(new int[]{1});
             
            bsearch.Step(0);
            
            Assert.True(bsearch.GetResult() == -1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == -1);
        }
        
        [Test]
        public void Array_Empty_Search0()
        {
            var bsearch = new BinarySearch(new int[]{});
             
            bsearch.Step(0);
            
            Assert.True(bsearch.GetResult() == -1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == -1);
        }
        
        [Test]
        public void Array_12_Search1()
        {
            var bsearch = new BinarySearch(new int[]{1, 2});
             
            bsearch.Step(1);
            
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 1);
        }
        
        [Test]
        public void Array_12_Search2()
        {
            var bsearch = new BinarySearch(new int[]{1, 2});
             
            bsearch.Step(2);
            
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 1);
            Assert.True(bsearch.Right == 1);
        }
        
        [Test]
        public void Array_99_Search49()
        {
            var arr = GenerateArray(1, 99);
            var bsearch = new BinarySearch(arr);
             
            bsearch.Step(49);
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 48);
            
            bsearch.Step(49);
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 25);
            Assert.True(bsearch.Right == 48);
            
            bsearch.Step(49);
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 37);
            Assert.True(bsearch.Right == 48);
            
            bsearch.Step(49);
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 43);
            Assert.True(bsearch.Right == 48);
            
            bsearch.Step(49);
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 46);
            Assert.True(bsearch.Right == 48);
            
            bsearch.Step(49);
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 48);
            Assert.True(bsearch.Right == 48);
        }

        private int[] GenerateArray(int from, int toIncluding)
        {
            int[] arr = new int[toIncluding - from + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + from;
            }

            return arr;
        }
    }
}