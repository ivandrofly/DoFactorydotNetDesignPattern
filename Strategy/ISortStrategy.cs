using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{
    namespace Generic
    {
        /// <summary>
        /// The 'Strategy' Interface
        /// </summary>
        interface ISortStrategy<T>
        {
            void Sort(List<T> list);
        }
    }

    /// <summary>
    /// The 'Strategy' Interface
    /// </summary>
    interface ISortStrategy
    {
        void Sort(List<string> list);
    }
}