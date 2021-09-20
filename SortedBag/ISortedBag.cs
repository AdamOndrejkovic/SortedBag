using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SortedBag
{
    public interface ISortedBag
    {
        List<int> Items { get; }
        int Count { get; }
        void Add(int item);
        int GetMin();
        int FetchMin();
    }
}