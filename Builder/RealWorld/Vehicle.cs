
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
    /// The 'Product' class
    /// </summary>
    class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor
        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", _parts["doors"]);
        }
    }
}