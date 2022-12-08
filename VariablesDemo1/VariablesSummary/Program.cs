//Integers 

int x = 10;
x = x * 2;
x++;
Console.WriteLine(x); //21 

// Strings 

string product = "Monitor"; 

product = product.ToUpper();
Console.WriteLine(product);

// Double 

double first = 2.5; 
double pi = Math.PI;

Console.WriteLine(first);
Console.WriteLine(pi);
double products = first * pi; 
Console.WriteLine(products);
double products2 = first * Math.PI;
Console.WriteLine(products2);
// Decimal (Money) 

decimal charge = 10.25m; 
decimal perc = charge / 3;
Console.WriteLine(perc);

// Boolean 
bool finished = false;
Console.WriteLine(finished);
bool another = !finished; 
Console.WriteLine(another);


Console.WriteLine();
Console.WriteLine("Expressions that are ture or false");
int q = 20; 
bool test1 = (q > 20);
Console.WriteLine(test1);

Console.WriteLine(q > 30); //Expect to see false 
Console.WriteLine(q == 20); //Expect to see true 
Console.WriteLine(q != 20); //False 
Console.WriteLine( !(q != 20) ); // Two nots equal true. 

// Lets' add in "and" "or" 
int j = 10;
int k = 11;

Console.WriteLine( (j == 10) && (k == 11) );
Console.WriteLine((j == 10) && (k == 12));
Console.WriteLine( (j == 10) || (k == 12) );


