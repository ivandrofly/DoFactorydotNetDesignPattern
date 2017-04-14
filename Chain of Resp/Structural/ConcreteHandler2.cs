using System;

namespace DoFactory.GangOfFour.Chain.Structural
{
    /// <summary>
    /// The 'ConcreteHandler2' class
    /// </summary>
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {

                Console.WriteLine("{0} handled request {1}", this.GetType().Name, request);
            }
            else if (successor != null)
            {

                successor.HandleRequest(request);

            }
        }
    }
    
}