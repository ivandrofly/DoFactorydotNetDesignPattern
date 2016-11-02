using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
