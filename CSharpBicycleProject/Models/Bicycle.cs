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

    public void CleanFrame()
    {
        Console.WriteLine("We wash our bike frames with non-abrasive detergent.");
        Console.WriteLine("We rinse and dry our bike frames for a prestine shine.");
    }

    public void AirTires()
    {
        Console.WriteLine("We air our bike tires to a consistant 32 psi.");
        Console.WriteLine("We test each tire prior to sale for proper air pressure.");
    }

    public void TestRide()
    {
        Console.WriteLine("We test ride our bicycles to ensure a proper ride");
        Console.WriteLine("We check all connections after our test ride to ensure safety.");
    }


    public override string ToString()
    {
        return $"{this.GetType().Name} ${Price}";
    }


} // end
