using System;
namespace DoFactory.GangOfFour.Command.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Command Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}
/*
OUTPUT:
    Current value = 100(following + 100)
    Current value = 50(following - 50)
    Current value = 500(following * 10)
    Current value = 250(following / 2)

    ---- Undo 4 levels
    Current value = 500 (following* 2)
    Current value = 50(following / 10)
    Current value = 100(following + 50)
    Current value = 0(following - 100)

    ---- Redo 3 levels
    Current value = 100 (following + 100)
    Current value = 50(following - 50)
    Current value = 500(following * 10)
*/
