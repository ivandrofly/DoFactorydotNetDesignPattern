using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Decorator.RealWorld
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class LibraryItem
    {
        private int _numCopies;

        // Property
        public int NumCopies
        {
            get => _numCopies;
            set => _numCopies = value;
        }

        public abstract void Display();
    }

}

