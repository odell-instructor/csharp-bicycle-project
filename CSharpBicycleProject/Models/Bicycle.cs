namespace CSharpBicycleProject;

internal abstract class Bicycle : IBicycle
{
    public IWheelInterface Wheel { get; }
    public string SerialNumber { get; set; }
    public abstract BikeColor FrameColor { get; set; }
    public abstract decimal Price { get; }
    public abstract string Model { get; }
    public abstract string Style { get; }
    public abstract int StartNumber { get; }

    public Bicycle(IWheelInterface wheel)
    {
        Wheel = wheel;
    }

    public void Paint(BikeColor color)
    {
        FrameColor = color;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name} ${Price}";
    }


} // end
