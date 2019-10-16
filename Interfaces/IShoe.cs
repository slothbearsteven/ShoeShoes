namespace ShoeStore.Interfaces
{
    public interface IShoe
    {
        string Name { get; set; }
        decimal Size { get; set; }
        decimal Price { get; set; }
        string Color { get; set; }

        // Brand
    }
}
