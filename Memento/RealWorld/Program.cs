using System;

/// <summary>
/// This real-world code demonstrates the Memento pattern which temporarily saves and then restores the SalesProspect's internal state.
/// </summary>
namespace DoFactory.GangOfFour.Memento.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Memento Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);

            // Wait for user
            Console.ReadKey();

        }

    }
}

//Name:   Noel van Halen
//Phone:  (412) 256-0990
//Budget: 25000

//Saving state --

//Name:   Leo Welch
//Phone:  (310) 209-7111
//Budget: 1000000

//Restoring state --

//Name:   Noel van Halen
//Phone:  (412) 256-0990
//Budget: 25000