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