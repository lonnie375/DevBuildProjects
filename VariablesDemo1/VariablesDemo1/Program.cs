// See https://aka.ms/new-console-template for more information

//Creating variables below 
//Creates a variable called x 
//It puts a value there of 10 
//Think about the memory of a computer. 0 to 7 billion and something 
//When creating a variable you are giving a slot of memory a name. Name is x and the value is 10
//This one step is called initialization 
//int x: is just creating the variable or declaring the variable. 
int x;
x = 10; 
Console.WriteLine(x);

////We can change the value of x after it has already been ran 
x = 20; 
Console.WriteLine(x);

x = x + 5;
Console.WriteLine(x);

x++; 
Console.WriteLine(x);

x += 6;
Console.WriteLine(x);

x--;
Console.WriteLine(x);

x -= 5;
Console.WriteLine(x);

x = x * 2;
Console.WriteLine(x);

x = x / 2;
Console.WriteLine(x);

//C# rounds down  
x = 17;
x /= 3;
Console.WriteLine(x);