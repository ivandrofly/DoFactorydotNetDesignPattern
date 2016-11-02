using System;

namespace DoFactory.GangOfFour.Visitor.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Visitor Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }

}