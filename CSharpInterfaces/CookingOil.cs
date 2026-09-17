namespace CSharpInterfaces;

internal class CookingOil(string name, int quantityPerItem) : LiquidGood
{
    public string Name { get; set; } = name;
    public int QuantityPerItem { get; set; } = quantityPerItem;

    public void MakeGood(int quantityMade)
    {
        Console.WriteLine($"Made: {Name}, Quantity: {quantityMade}");
    }
}
