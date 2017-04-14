namespace DoFactory.GangOfFour.Chain.Structural
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(int request);

    }
}