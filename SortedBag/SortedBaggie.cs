using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SortedBag
{
    public class SortedBaggie: ISortedBag
    {
        public List<int> Items { get; private set; }

        public int Count
        {
            get
            {
                return Items.Count;
            }
            
        }

        public SortedBaggie()
        {
            Items = new List<int>();
        }
        
        
        public void Add(int item)
        {
            Items.Add(item);
        }

        public int GetMin()
        {
            if (Count == 0)
                throw new InvalidOperationException("Sorted bag is empty");
            return Items.Min();
        }

        public int FetchMin()
        {
            if (Count == 0)
                throw new InvalidOperationException("Sorted bag is empty");
            int result = Items.Min();
            Items.Remove(result);
            return result;
        }
    }
}