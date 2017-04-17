namespace DoFactory.GangOfFour.Builder.RealWorld
{
    interface IVehicleBuilder
    {
        Vehicle Vehicle { get; }

        void BuildDoors();
        void BuildEngine();
        void BuildFrame();
        void BuildWheels();
    }
}