namespace CSharpBicycleProject;

internal abstract class RoadBike : Bicycle
{
    public override string Style { get; } = "Road Bike";

    protected RoadBike(IWheelInterface wheel)
        : base(wheel) { }

} // end class
