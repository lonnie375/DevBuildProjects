//Boolean (bool) 
//** Has two choices; True or False
bool goAgain = true;
Console.WriteLine(goAgain);
goAgain = false;
Console.WriteLine(goAgain);
//** How to flip boolean from true to false or vice versa 
goAgain = !goAgain;
Console.WriteLine(goAgain);


// int 
int count = 10;
Console.WriteLine(count);

// Operators: increment and decrement 
count++;
Console.WriteLine(count);
count--;
Console.WriteLine(count);

count *= 2;
Console.WriteLine(count);
// char 
//** We use the single quotes around it, and only one character 
Console.WriteLine("Character tests");
char ch = 'A'; 
Console.WriteLine(ch);
ch = '[';
Console.WriteLine(ch);


// double/float 
Console.WriteLine();
Console.WriteLine("Floaint point (mainly double) tests");
double d = 3.14;
Console.WriteLine(d);

// The built-in Math library works mostly with doubles 
// How about the square root 

double s = Math.Sqrt(d);
Console.WriteLine(s);

d = Math.PI;
Console.WriteLine(d);

// decimal type for handling money 
// ** too many programmers don't know this and use floating point! No! 
Console.WriteLine();
Console.WriteLine("Decimal break");
decimal balance = 1000m;
decimal rate = .025m;
Console.WriteLine(balance * rate);

// Arrays 
// To declare an array, you start with the type that it holds followed by []
// That entire thing, e.g. int[], is the type. 
// This is unique to C# 

int[] numbers = new int [5];
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4; 
numbers[4] = 5; 

foreach (int i in numbers)
{
    Console.WriteLine(i);
}


// Strings 
// Basic string concepts, plus string manipulations 
// Search for substring, append to a string (sort of), split a string, 
// join an array of strings back into a string 
// Strins are technically objects stored in shared memory, but C# 
// does a good job of hiding that, so we don't really need to know that 
// strings are immuteable 

string words = "The quick brown fox jumped over the lazy dogs .";
Console.WriteLine(words);

string[] parts = words.Split(); 

foreach(string word in parts)
{
    Console.WriteLine(word);
}

// Join them back together into a snew string 
string copy = string.Join(" ", parts);
Console.WriteLine(copy);

// Search for a indexOf "fox"
int pos = words.IndexOf("fox");
Console.WriteLine(pos);

// Determines if a word exists
pos = words.IndexOf("cat"); 
if (pos >= 0)
{
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine("Not here");
}

// Append a string 
words += " No cats allowed.";
Console.WriteLine(words);


// Lists 
Console.WriteLine();
Console.WriteLine("List tests (and class instances and ToString)");
List<Rectangle> myList =new List<Rectangle>();
myList.Add(new Rectangle(10.5, 20.6, "First"));
myList.Add(new Rectangle(25.6, 13.2, "Second"));
myList.Add(new Rectangle(12.9, 1.3, "Third"));

foreach(Rectangle rect in myList)
{
    Console.WriteLine(rect);
}

// Dictionaries 
// Remember dictionaries map fromone thing to another 
// But we an also think of them as "key-value pairs" 
// Try to embrance *both* ways of looking at it. 
Console.WriteLine();
Console.WriteLine("Dictionary Practice");
Dictionary<string, int> spelling = new Dictionary<string, int>();  

//Two ways to add to the dictionary
spelling["one"] = 1;
spelling["fifty"] = 50;

// or.. 

spelling.Add("One Hundred", 100); // Same effect but we're adding this mapping as a single pair 

// Let's Loop! 
//foreach(var item in spelling)
foreach(KeyValuePair<string, int> pair in spelling) 
{
    Console.WriteLine(pair.Key + ": " +  pair.Value);
}

//Enums
// Justlike "bool" can hold two possible values, enums have a limited amount. 
// This "Season" allows for four different values. 
Console.WriteLine();
Console.WriteLine("Lets review Enums");
Season now = Season.summer;
Console.WriteLine(now);
enum Season
{
    winter,
    summer,
    spring,
    fall
}



class Rectangle
{
    public double length { get; set; }
    public double height { get; set; }
    public string name { get; set; }

    public Rectangle(double length, double height, string name)
    {
        this.length = length;
        this.height = height;
        this.name = name;
    }

    public override string ToString()
    {
        return $"{name}: Length {length} Height {height} Perimter: {2 * length + 2 * height}"; 
    }
    
}