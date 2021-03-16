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

            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 0);
            
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
            
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 2);
            Assert.True(bsearch.Right == 2);
            
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
            
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 2);
            Assert.True(bsearch.Right == 2);
            
            bsearch.Step(4);
            
            Assert.True(bsearch.GetResult() == -1);
            Assert.True(bsearch.Left == 3);
            Assert.True(bsearch.Right == 2);
        }

        [Test]
        public void Array_123_Search0()
        {
            var bsearch = new BinarySearch(new int[]{1, 2, 3});
             
            bsearch.Step(0);
            
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == 0);
            
            bsearch.Step(0);
            
            Assert.True(bsearch.GetResult() == -1);
            Assert.True(bsearch.Left == 0);
            Assert.True(bsearch.Right == -1);
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
            
            Assert.True(bsearch.GetResult() == 0);
            Assert.True(bsearch.Left == 1);
            Assert.True(bsearch.Right == 1);
            
            bsearch.Step(2);
            
            Assert.True(bsearch.GetResult() == 1);
            Assert.True(bsearch.Left == 1);
            Assert.True(bsearch.Right == 1);
        }
    }
}