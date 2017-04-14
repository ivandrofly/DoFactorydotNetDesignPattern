using System;

/// <summary>
/// This structural code demonstrates the Chain of Responsibility pattern in which several linked
/// objects (the Chain) are offered the opportunity to respond to a request or hand it off to the object next in line. 
/// </summary>
namespace DoFactory.GangOfFour.Chain.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Chain of Responsibility Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}

//ConcreteHandler1 handled request 2
//ConcreteHandler1 handled request 5
//ConcreteHandler2 handled request 14
//ConcreteHandler3 handled request 22
//ConcreteHandler2 handled request 18
//ConcreteHandler1 handled request 3
//ConcreteHandler3 handled request 27
//ConcreteHandler3 handled request 20