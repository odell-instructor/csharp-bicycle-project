namespace CSharpBicycleProject;

internal abstract class Wheel : IWheelInterface
{
    public abstract int WheelSize { get; }
    public abstract bool IsWide { get; }


    public override string ToString()
    {
        return $"{WheelSize} inch {this.GetType().Name} wheels";
    }

} // end class
