namespace CSharpInterfaces;

interface LiquidGood
{
    // All members are public by default
    string Name { get; set; }
    int QuantityPerItem { get; set; }

    void MakeGood(int quantityMade);
}
