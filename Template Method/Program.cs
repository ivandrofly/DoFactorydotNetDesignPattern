using System;

/// <summary>
/// Definition:
/// Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
/// Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
/// </summary>
namespace DoFactory.GangOfFour.Template.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Template Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
