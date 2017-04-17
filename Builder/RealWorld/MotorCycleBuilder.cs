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
    /// The 'ConcreteBuilder1' class
    /// </summary>
    class MotorCycleBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; }

        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public void BuildFrame()
        {
            Vehicle["frame"] = "MotorCycle Frame";
        }

        public void BuildEngine()
        {
            Vehicle["engine"] = "500 cc";
        }

        public void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }

        public void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }
    }
}
