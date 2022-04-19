namespace CSharpBicycleProject;

internal class Downhill : MountainBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Black;
    public override decimal Price { get; } = 699.99m;
    public override int StartNumber { get; } = 852654;
    public override string Model { get; } = "DB505";

    public Downhill(IWheelInterface wheel)
        : base(wheel) { }

} // end class
