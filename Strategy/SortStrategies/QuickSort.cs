using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class QuickSort : ISortStrategy /* ISortStrategy<string>*/
    {
        public void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
