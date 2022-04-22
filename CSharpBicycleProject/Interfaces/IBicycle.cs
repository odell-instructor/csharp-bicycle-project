namespace CSharpBicycleProject;

internal interface IBicycle
{
    IWheelInterface Wheel { get; }
    BikeColor FrameColor { get; set; }
    decimal Price { get; }
    string Model { get; }
    string Style { get; }
    string SerialNumber { get; set; }
    int StartNumber { get; }

    void Paint(BikeColor color);

    // Prepare for sale
    void CleanFrame();
    void AirTires();
    void TestRide();

} // end interface
