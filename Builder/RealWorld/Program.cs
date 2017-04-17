
using System;
using System.Collections.Generic;

/// <summary>
/// Separates object construction from its representation.
/// 
/// Separate the construction of a complex object from its representation so that
/// the same construction process can create different representations.
/// 
/// Frequence of use: 2 medium low.
/// </summary>
namespace DoFactory.GangOfFour.Builder.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Builder Design Pattern.
    /// </summary>
    public class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            IVehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            // Display built vehicle info
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}

/*
Ouput: 
---------------------------
Vehicle Type: Scooter
 Frame  : Scooter Frame
 Engine : none
 #Wheels: 2
 #Doors : 0

---------------------------
Vehicle Type: Car
 Frame  : Car Frame
 Engine : 2500 cc
 #Wheels: 4
 #Doors : 4

---------------------------
Vehicle Type: MotorCycle
 Frame  : MotorCycle Frame
 Engine : 500 cc
# Wheels: 2
# Doors : 0

*/
