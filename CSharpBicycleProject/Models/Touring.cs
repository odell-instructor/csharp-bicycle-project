namespace CSharpBicycleProject;

internal class Touring : RoadBike
{
    public override BikeColor FrameColor { get; set; } = BikeColor.Blue;
    public override decimal Price { get; } = 499.99m;
    public override int StartNumber { get; } = 951357;
    public override string Model { get; } = "TB901";

    public Touring(IWheelInterface wheel)
        : base(wheel) { }

} // end class
