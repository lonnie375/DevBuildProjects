//Ram mod1 = new Ram();
//mod1.brand = "Grand Circus";
//mod1.type = "Whatever";
//mod1.gb = -500; 


//WHen they're private it won't let you assign a value to them. 
//Ram mod2 = new Ram();
//mod2.gb = -500; //inaccessible because it's private now 


Ram mod1 = new Ram("Intel", "DDR3", 32);
Console.WriteLine(mod1.GetBrand());
mod1.SetType("DDR2");
Console.WriteLine(mod1.GetType());
mod1.SetType("Hellow"); //Notice that this didn't work because it's not one of the correct values 
Console.WriteLine(mod1.GetType());


mod1.SetGetGB(100);
Console.WriteLine(mod1.GetGB());
public class Ram
{
    // Common technique ("pattern") -- make all our member variables private 
    // This is generally true for most programming languages, not just C# 
    private string brand { get; set; }
    private string type { get; set; }
    private int gb { get; set; }

    public Ram(string brand, string type, int gb)
    {
        this.brand = brand;
        if (type == "DDR" || type == "DDR2" || type == "DDR3" || type == "DDR4")
        {
            this.type = type; 
        }else
        {
            this.type = "DDR"; 
        }
        if (gb >= 1 && gb <= 32)
        {
            this.gb = gb; 
        }
        else
        {
            this.gb = 4; 
        }
    }   

    //Lets set up this protection: 
    //   1. The user cannot change the brand but can look at it (Read-Only) 
    //   2. The user can set the type and look at it, but is limited to available types 
    //   3. The user can set the GB and look at it, but is limited the range 1 - 32. 


    // Methods called getters/setters 

    public string GetBrand()
    {
        return this.brand;
    }

    public string GetType()
    {
        return this.type; 
    }

    public void SetType(string type)
    {
        //Valid options: DDR, DDR2, DDR3, DDR4

        if (type == "DDR" || type == "DDR2" || type == "DDR3" || type == "DDR4")
        {
            this.type = type; 
        }
        else
        {
            //Normally we would write something to a system log file for the developer 
        }

    }

    public int GetGB()
    {
        return gb;
    }

    public void SetGetGB(int gb)
    {
        if (gb >= 1 && gb <= 32)
        {
            this.gb = gb; 
        }
    }
}