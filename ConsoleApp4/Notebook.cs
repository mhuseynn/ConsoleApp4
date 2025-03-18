namespace ConsoleApp4;

public class Notebook : Product
{
    
    private byte ram;

    public byte RAM
    {
        get { return ram; }
        set {
            if (value>0)
            {
                ram = value;
            }
        }
    }
    
    
    public int Storage { get; set; }



    public Notebook(string name, int count, double price, byte ram, int storage) : base(name, count, price)
    {
        RAM = ram;
        Storage = storage;
    }

    public string GetFullInfo()
    {
        return $"Name: {Name}\nCount: {Count}\nPrice: {Price:C}\nRAM: {RAM}GB\nStorage: {Storage}GB\n";
    }

    public void ShowFullData()
    {
        Console.WriteLine(GetFullInfo());
    }
}
