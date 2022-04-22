namespace CSharpBicycleProject;

internal class BikePrep
{
    public void PrepareForSale(IBicycle bicycle)
    {
        // Registration - use for serial number registration
        Registration.RegisterBikeSerial(bicycle);

        // print a brochure
        Brochure.PrintBrochure(bicycle);

        // Call the 3 methods from IBicycle
        bicycle.CleanFrame();
        bicycle.AirTires();
        bicycle.TestRide();
    }
} // end class


internal class Brochure
{
    public static void PrintBrochure(IBicycle bike)
    {
        Console.WriteLine($"Printing Brochure for {bike.GetType().Name} Bicycle.");
    }
} // end class


internal class Registration
{
    public static void RegisterBikeSerial(IBicycle bike)
    {
        Console.WriteLine($"Allocating {bike.GetType().Name} Serial Number for Registration");
    }
}