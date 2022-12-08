string name = "Fred";
Console.WriteLine(name);

string upperName = name.ToUpper();  //Strings are immutable means it can't be changed 
Console.WriteLine(upperName);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);
Console.WriteLine(name[2]);
Console.WriteLine(name[3]);

Console.WriteLine(name.ToLower());

// Floating Point Types 
double pi = 3.1415926;
Console.WriteLine(pi);

double pi2 = pi * 2; 
Console.WriteLine(pi2);

Console.WriteLine(Math.PI);
Console.WriteLine(Math.Sqrt(pi));

double q = Math.Sqrt(25);
Console.WriteLine(q);

decimal amount = 99.95m;
Console.WriteLine(amount);

amount = amount * 5; 
Console.WriteLine(amount);  

bool passed= true;
Console.WriteLine(passed);
passed= false;
Console.WriteLine(passed);

passed = !passed;
Console.WriteLine(passed);