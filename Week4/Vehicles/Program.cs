Sedan myCar = new Sedan(true, 4, 4, "Blue");

myCar.Drive();

RaceCar myRaceCar = new RaceCar(4, "Red", 400);
myRaceCar.Drive();

RaceCar secondRaceCar = new RaceCar(3, "Yellow", 1000);
Console.WriteLine();
Console.WriteLine("Everybody Drive");

List<Vehicle> cars = new List<Vehicle>();
cars.Add(myCar);
cars.Add(myRaceCar); 
cars.Add(secondRaceCar);

foreach(Vehicle vehicle in cars)
{
   vehicle.Drive();
   
}

//This commented code demonstrates polymorphism 
//Vehicle something;
//something = myCar;
//something.Drive();

//something = myRaceCar;
//something.Drive();

public class Vehicle
{
    public int wheelCount { get; set; }
    public string color { get; set; }

    public Vehicle(int wheelCount, string color)
    {
        this.wheelCount = wheelCount;
        this.color = color;
    }

        public virtual void Drive()
    {
        Console.WriteLine("I am driving.");
    }
}

public class Sedan : Vehicle
{
   public bool hasHatchBack { get; set; }
   public int doorCount { get; set; }

       //The information we pass in the Sedan constructor below will be passed into the Vehicle constructor above. 
    public Sedan(bool hasHatchBack, int doorCount, int sedanWheelCount, string SedanColor) : base(sedanWheelCount, SedanColor)  
    {
        this.hasHatchBack = hasHatchBack;
        this.doorCount = doorCount;
    }

    public override void Drive()
    {
        Console.WriteLine("I am driving the speed limit!");
    }
}

public class RaceCar : Vehicle
{
    public int engineSize { get; set; }
    public RaceCar(int wheelCount, string color, int engineSize) : base(wheelCount, color)
    {
        this.engineSize = engineSize;
    }

    public override void Drive()
    {
        Console.WriteLine($"I am speeding with my {engineSize}!");
    }
}