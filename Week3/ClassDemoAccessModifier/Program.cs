Car first = new Car("Chevy", "Trax", Color.Blue);
Console.WriteLine(first.GetMake());
Console.WriteLine(first.GetModel());
first.SetColor(Color.Red);
Console.WriteLine(first.GetColor());
first.SetColor(Color.Silver);
Console.WriteLine(first.GetColor());
//first.color = "Red";
//Console.WriteLine(first.color);

//This is how you would access the colors in the enum 
Color newColor =  Color.Red; //We are limited to 4 choices 

Color pianoColor = Color.Black;
pianoColor = Color.Red; 


enum Color
{
    Red,Blue,Black, Silver
}


 class Car
{
    //Attributes that cannot be changed 
    private string make { get; set; }
    private string model { get; set; }

    //Attributes that can be changed 
    //You have to make a 
    private Color CarColor { get; set; }

    //Constructor 
    public Car(string make, string model, Color color)
    {
        this.make = make;
        this.model = model;
        this.CarColor = color;
    }

    //Methods 
    public string GetMake()
    {
        return make;
    }
   
    public string GetModel()
    {
        return model;   
    }

    // Color has both a "getter" and "setter" so we can only look at it. We cannot change it. 
    public Color GetColor()
    {
        return CarColor;
    }

    public void SetColor(Color _color)
    {
       
            CarColor = _color;
        
  
         
    }
}