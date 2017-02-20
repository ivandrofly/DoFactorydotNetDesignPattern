using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.GangOfFour.Command.RealWorld
{

    /// <summary>
    /// The 'Command' Interface
    /// </summary>
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }
}
