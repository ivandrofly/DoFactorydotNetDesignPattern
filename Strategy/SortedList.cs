using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class SortedList
    {
        private List<string> _list = new List<string>();
        private /*readonly*/ ISortStrategy _sortstrategy;

        public SortedList(ISortStrategy sortStrategy)
        {
            _sortstrategy = sortStrategy;
        }

        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortstrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results
            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
