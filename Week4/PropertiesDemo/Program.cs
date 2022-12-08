Ram mod1 = new Ram("Intel", "DDR3", 32);

//This runs the Brand method below that is returning what we set inside of object above. 
Console.WriteLine(mod1.Brand);
Console.WriteLine(mod1.Stock);

mod1.Type = "DDR2";
Console.WriteLine(mod1.Type);

//This value isn't allowed. 
mod1.Type = "Hellow";
Console.WriteLine(mod1.Type);


mod1.Stock = 100;
Console.WriteLine(mod1.Stock);
public class Ram
{
    private string _Brand { get; set; }
    private string _Type { get; set; }
    private int _GB { get; set; }

    private int _Stock { get; set; }
    public string  Vendor { get; set; }

    public Ram(string brand, string type, int gb)
    {
        this._Brand = brand;

        if (type == "DDR" || type == "DDR2" || type == "DDR3" || type == "DDR4")
        {
            this._Type = type;
        }
        else
        {
            this._Type = "DDR";
        }


        if (gb >= 1 && gb <= 32)
        {
            this._GB = gb;
        }
        else
        {
            this._GB = 4;
        }
        _Stock = 10; // THis one we created the private variable so we can access it 
        Vendor = "Amazon"; // We can't acces the private variable thats behind the scenese
    }

    //This works just like the methods we created in GetterSetterDemo
    public string Brand
    {
        get { return this._Brand; } 
    }

    public string Type
    {
        get { return this._Type; }
        set
        {
            if (value == "DDR" || value == "DDR2" || value == "DDR3" || value == "DDR4")
            {
                this._Type = value;
            }
        }
    }

    public int Stock
    {
        get
        {
            return _Stock; 
        }
        set
        {
            this._Stock = value;
        }
    }
}