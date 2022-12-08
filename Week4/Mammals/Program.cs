
Dog first = new Dog() { name = "fido", hairColor = "black", barkVolume = 8, legCount = 4 };
//Console.WriteLine(first);

Dog second = new Dog() { name = "Nellie", hairColor = "Yellow", barkVolume = 5, legCount = 4 };

//See constructors aren't required and you can control what information you can use 
Dog secondThird = new Dog() { name = "Roger", hairColor = "Brown" }; 

Orangutan third = new Orangutan() { name = "Dunston", hairColor = "orange", thumbLength = 3, legCount = 2 };
//Console.WriteLine(third);

List<Mammal> pets = new List<Mammal>();
pets.Add(first);
pets.Add(second);
pets.Add(third);
pets.Add(secondThird);

//**We can access all of the properties in the mammal class but we can't access the properties/methods in the dog or orangutan classes 


foreach (Mammal m in pets)
{
    //Console.WriteLine($"{m.name} {m.legCount} {m.hairColor}");
    string info = m.ToString();
    Console.Write(m.name);
    Console.WriteLine(info); //This is going to call all of the ToStrings() accordingly. This happens because "override" is used so the most specific one is used 
}


public class Mammal
{
    public string name { get; set; }
    public string hairColor { get; set; }
    public int legCount { get; set; }
    public void Walk()
    {
        Console.WriteLine("I am walking.");
    }


    //We are overriding what's called a "virtual" function. 
    // A virtual function can be overriden 
    public override string ToString()
    {
        return "This is a mammal"; 
    }
}

public class Dog : Mammal
{
    public int barkVolume { get; set; }

    public override string ToString()
    {
        return $"Dog nameed {name}, hair color:{hairColor}, leg count:{legCount}, barks at volume:{barkVolume}"; 
    }
}

public class Orangutan : Mammal
{
    public int thumbLength { get; set; }

    public override string ToString()
    {
        return $"Orangutain nameed {name}, hair color:{hairColor}, leg count:{legCount}, thumb length:{thumbLength}";
    }
}