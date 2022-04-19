namespace CSharpBicycleProject;

internal class CrossCountry : MountainBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Green;
    public override decimal Price { get; } = 599.99m;
    public override int StartNumber { get; } = 258456;
    public override string Model { get; } = "MB605";

    public CrossCountry(IWheelInterface wheel)
        : base(wheel) { }


} // end class
