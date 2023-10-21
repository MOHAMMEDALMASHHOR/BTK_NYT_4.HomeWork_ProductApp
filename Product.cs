public class Product{
    private string name;
    public string Name
    {
        get { return name; }
        set { if (value.Length<3 || value.Length>8)
        {
            throw new Exception($"{value} is invalid to be a products name its letters must be between 3 and 8 characters");
        }name = value; }
    }
    private float price;
    public float Price
    {
        get { return price; }
        set { if (value<0)
        {
            throw new Exception($"{value} is invalid to be a product's price, it must be more than or equale 0");
            
        }price = value; }
    }
    private int quantity;
    public int Quantity
    {
        get { return quantity; }
        set { if (value<0)
        {
            throw new Exception($"{value} is invalid to be a product's quantity, it must be more than or equale 1");
            
        }quantity = value; }
    }

    
    public DateTime Date { get; private set; }

    public Product(string name)
    {
        Name = name;
        System.Console.WriteLine(Name);
        Date = DateTime.Now;
        System.Console.WriteLine($"The Date of the registraion of this product is: {Date}");
        
    }
    public Product (string name, float price):this(name)
    {
        Name = name;
        Price = price;
        
    }
    public Product (string name, float price, int quantity):this(name,price)
    {
        
        Quantity = quantity;
    }
    public float GetTotalPrice(){
        return Price*Quantity;
    }
}
