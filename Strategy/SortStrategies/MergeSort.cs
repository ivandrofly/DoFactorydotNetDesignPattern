using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class MergeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}
