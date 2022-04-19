namespace CSharpBicycleProject;

internal class GoldFrame : IBikeOption
{
    public string OptionType { get; } = "Gold Frame";
    public decimal OptionAmount { get; } = 149.95m;
}

internal class LeatherGrips : IBikeOption
{
    public string OptionType { get; } = "Leather Hand Grips";
    public decimal OptionAmount { get; } = 29.99m;
}

internal class LeatherSeat : IBikeOption
{
    public string OptionType { get; } = "Leather Seat";
    public decimal OptionAmount { get; } = 89.99m;
}

internal class WhiteTires : IBikeOption
{
    public string OptionType { get; } = "White Tires";
    public decimal OptionAmount { get; } = 19.99m;
}