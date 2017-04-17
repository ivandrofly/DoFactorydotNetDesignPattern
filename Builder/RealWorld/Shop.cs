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
    /// The 'Director' class
    /// </summary>
    class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(IVehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
