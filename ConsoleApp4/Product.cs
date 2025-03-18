namespace ConsoleApp4;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Count { get; set; }
    public bool IsStock { get; set; }


    private double price;
    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
            {
                price = value;
            }
        }
    }

    public Product(string name, int count, double price)
    {

        this.Name = name;
        this.Count = count;
        this.Price = price;
    }

    public void Sale()
    {
        if (Count == 0)
        {
            Console.WriteLine(" yoxdur!");
            return;
        }
        Count--;
        Console.WriteLine(" satıldı!");
    }
}