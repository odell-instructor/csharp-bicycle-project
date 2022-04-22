namespace CSharpBicycleProject;

internal class SampleReceipt
{
    private decimal total = 0.0m;
    private List<IBicycle> cartList;
    private List<IBikeOption> cartOptionsList;

    public SampleReceipt(List<IBicycle> bikeList, List<IBikeOption> optionList)
    {
        cartList = bikeList;
        cartOptionsList = optionList;

        // show title
        ShowTitle();
        // show columns header
        ShowColumnHeader();
        // show cart
        ShowCart();
        // prep for sale
    }

    private void ShowCart()
    {
        foreach (IBicycle bike in cartList)
        {
            Console.WriteLine($"{bike.GetType().Name,9} {bike.Price,26}");
            Console.WriteLine($"  {bike.FrameColor} Frame Color");
            Console.WriteLine($"  Model #:{bike.Model}");
            Console.WriteLine($"  Serial Number: {bike.SerialNumber}");
            total += bike.Price;
        }
        if(cartOptionsList.Count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("  Custom Options");
            foreach (IBikeOption option in cartOptionsList)
            {
                Console.WriteLine($"  {option.OptionType,9} {option.OptionAmount,14}");
                total += option.OptionAmount;
            }
        }
        ShowDashes();
        Console.WriteLine($"  Sub Total {"$" + total,24}");
        Console.WriteLine($"  Assembly Cost {"$49.99",19}");
        total += 49.99m;
        ShowDashes();
        Console.WriteLine($"  Total {"$" + total,28}");
    }

    private void ShowTitle()
    {
        Console.WriteLine($"{"ACME BICYCLE COMPANY",30}");
        Console.WriteLine($"{"123 Main St, City, St, Zip",33}");
        Console.WriteLine($"{"(000) 000 - 0000",27}");
        ShowDashes();
        Console.WriteLine($"{"MONEY RECEIPT",25}");
    }
    private void ShowColumnHeader()
    {
        Console.Write($"| Description ");
        Console.WriteLine($"{"| Price |",23}");
    }

    private void ShowDashes()
    {
        for (int i = 0; i < 40; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }

} // end class
