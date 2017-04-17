using System;
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
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class CarBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; }

        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public void BuildEngine()
        {
            Vehicle["engine"] = "2500 cc";
        }

        public void BuildWheels()
        {
            Vehicle["wheels"] = "4";
        }

        public void BuildDoors()
        {
            Vehicle["doors"] = "4";
        }
    }
}
