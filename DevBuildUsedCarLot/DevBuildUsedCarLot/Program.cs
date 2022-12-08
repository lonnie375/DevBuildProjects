using DevBuildUsedCarLot;

Console.WriteLine("Welcome to Grant Chirpus' Used Car Emporium!");

List<Car> carLot1 = new List<Car>();
Initialize(carLot1);


bool proceed = true; 
while (proceed)
{
    int user = PrintList(carLot1);

    if (user <= carLot1.Count)
    {
        CarPurchased(carLot1, user);
    }
    else if (user == carLot1.Count + 1)
    {
        AddCar(carLot1);
    }
    else
    {
        Console.WriteLine("GoodBye");
        proceed = false;
    }
   
}


//Create our cars 
static void Initialize(List<Car> carList)
{
    Car first = new Car("Nikolai", "Model S", 2021, 54999.90m);
    carList.Add(first);

    Car second = new Car("Ford", "Escape", 2021, 31999.90m);
    carList.Add(second);

    Car third = new Car("Nikolai", "Model S", 2021, 54999.90m);
    carList.Add(third);

    UsedCar fourth = new UsedCar("Hyonda", "Prior", 2015, 14795.50m, 35987.6);
    carList.Add(fourth);

    UsedCar fifth = new UsedCar("Cadillac", "Escalade", 2019, 80000.50m, 15000);
    carList.Add(fifth);

    UsedCar sixth = new UsedCar("GMC", "Arcadia", 2018, 25000m, 35000);
    carList.Add(sixth);
}

//Print out the car details that are in our lot 
static int PrintList(List<Car> carList)
{
    int count = 1;
    for(int i = 0; i < carList.Count; i++)
    {
        Console.WriteLine($"{count++}: {carList[i]}");
    }
    
    Console.WriteLine($"{count++}. Add a car");
    Console.WriteLine($"{count++}. Quit");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Which car would you like? "); 
    int userOption = int.Parse(Console.ReadLine());
    return userOption; 
}


//Pick the car the user wants to purchase 
static void CarPurchased(List<Car> carList, int userOption)
{

    Console.WriteLine(carList[userOption - 1]);
    Console.Write("Would you like to buy this car?(y/n) ");
  
    string userResponse = Console.ReadLine().ToLower();
    if (userResponse == "y")
    {
        carList.Remove(carList[userOption - 1]);
        Console.WriteLine("Excellent! Our finance department will be in touch shortly.");
    }
    else
    {
           //Will be break
        Console.WriteLine("Thank you");
    }
}

//User wants to add a car 
static void AddCar(List<Car> carList)
{
    Console.Write("Would you like to add a 'New' or 'Used' car? "); 
    string userChoice = Console.ReadLine().ToLower();

    Console.Write("Make: ");
    string make = Console.ReadLine().ToLower();

    Console.Write("Model: ");
    string model = Console.ReadLine().ToLower();

    Console.Write("Year: ");
    int year = int.Parse(Console.ReadLine());

    Console.Write("Price: ");
    decimal price = decimal.Parse(Console.ReadLine());

    if (userChoice == "new")
    {
        carList.Add(new Car(make, model, year, price)); 
    } 
    else if (userChoice == "used")
    {
        Console.Write("Mileage: ");
        double mileage = double.Parse(Console.ReadLine());

        carList.Add(new UsedCar(make, model, year, price, mileage)); 
    }
}