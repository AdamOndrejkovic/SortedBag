using System;
using System.Linq;
using SortedBag;
using Xunit;
namespace XUnitTest
{
    public class SortedBagTest
    {

        [Fact]
        public void CreateSortedBag()
        {
            ISortedBag bag = new SortedBaggie();
            Assert.NotNull(bag);
            Assert.True(bag is ISortedBag);
            Assert.Equal(0, bag.Count);
            Assert.Empty(bag.Items);
        }

        [Fact]
        public void Add()
        {
            int x = 1;
            ISortedBag bag = new SortedBaggie();
            
            Assert.Empty(bag.Items);
            Assert.Equal(0,bag.Count);
            
            bag.Add(x);
            
            Assert.True(bag.Items.Contains(x));
            Assert.Equal(1,bag.Count);
        }

        [Fact]
        public void AddSameItemTwice()
        {
            int x = 12;
            ISortedBag bag = new SortedBaggie();
            bag.Add(x);
            Assert.Contains(x, bag.Items);
            
            bag.Add(x);
            
            Assert.Equal(2, bag.Items.Count(i => i == x));
        }

        [Fact]
        public void GetEmptySortedBaggieExpectExceptionToBeThrown()
        {
            ISortedBag bag = new SortedBaggie();
            Assert.Empty(bag.Items);

            var ex = Assert.Throws<InvalidOperationException>(() => bag.GetMin());
            Assert.Equal("Sorted bag is empty", ex.Message);
        }

        [Fact]
        public void GetMinMoreItemsInItemsCollection()
        {
            ISortedBag bag = new SortedBaggie();
            bag.Add(2);
            bag.Add(1);
            int oldCount = bag.Count;

            int result = bag.GetMin();
            
            Assert.Equal(1, result);
            Assert.Equal(oldCount, bag.Count);
        }
        
        [Fact]
        public void FetchEmptySortedBaggieExpectExceptionToBeThrown()
        {
            ISortedBag bag = new SortedBaggie();
            Assert.Empty(bag.Items);

            var ex = Assert.Throws<InvalidOperationException>(() => bag.FetchMin());
            Assert.Equal("Sorted bag is empty", ex.Message);
        }
        
        [Fact]
        public void FetchMinMoreItemsInItemsCollection()
        {
            ISortedBag bag = new SortedBaggie();
            bag.Add(2);
            bag.Add(1);
            int oldCount = bag.Count;

            int result = bag.FetchMin();
            
            Assert.Equal(1, result);
            Assert.Equal(oldCount -1, bag.Count);
        }
        
    }
}