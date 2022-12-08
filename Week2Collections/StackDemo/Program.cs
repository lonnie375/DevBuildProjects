Stack<string> cards = new Stack<string>();
//First in First Out 
//Lets add to our Stack by using Push 
cards.Push("3D");
cards.Push("AS");
cards.Push("QH");
cards.Push("10D"); 

//Lets take off the top of the stack by using Pop 
string next= cards.Pop();
Console.WriteLine(next);
Console.WriteLine(cards.Count); //We deleted from the stack 

next= cards.Pop();
Console.WriteLine(next); //removing QH
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next); //removing AS
Console.WriteLine(cards.Count);

next = cards.Pop();
Console.WriteLine(next); //removing3D
Console.WriteLine(cards.Count);

//next = cards.Pop();
//Console.WriteLine(next); //SHould be an exception since the stack is empty!
//Console.WriteLine(cards.Count);

Console.WriteLine();
Console.WriteLine();

//Lets do some Queue 
//Last In First Out
Console.WriteLine("Now lets do some Queue practice.");
Queue<int> nums = new Queue<int>();

nums.Enqueue(5); //5 got there first so they will be served first 
nums.Enqueue(10);
nums.Enqueue(15);
nums.Enqueue(20);

Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);
Console.WriteLine(nums.Dequeue());
Console.WriteLine(nums.Count);



Console.WriteLine();
Console.WriteLine("Advance Stack Stuff Below");

cards.Clear(); //This empties out the stack. It clears it 

cards.Push("5D");
cards.Push("JH");
cards.Push("3S");

Console.WriteLine(cards.Pop()); //Expect 3S

//Let's just look at the top of the deck but not pull it off 
string top = cards.Peek();
Console.WriteLine($"The top is {top} but we didn't remove it.");

//We didn't remove JH so it stills there. 

Console.WriteLine(cards.Pop()); // Expect JH

cards.Push("9H");
cards.Push("10D");
cards.Push("KS");

Console.WriteLine(cards.Pop());

cards.Push("5D");

// Now lets draw them all of 
Console.WriteLine("Lets draw the rest of the cards.");
while (cards.Count > 0)
{
    next = cards.Pop();
    Console.WriteLine($"We just drew {next}");
}

Console.WriteLine($"THe count of the deck is now {cards.Count()}."); //Expect to see 0


//One more stack demo
Console.WriteLine();
Console.WriteLine("Lets put 5 cards on and draw them all off");
cards.Clear();
cards.Push("AD");
cards.Push("2D");
cards.Push("3D");
cards.Push("4D");
cards.Push("5D");

while (cards.Count > 0)
{
    Console.WriteLine(cards.Pop());
}


//MOne more queue demo 
Console.WriteLine();
Console.WriteLine("Lets put 5 numbers in a queue, then we will drawm them all off");
nums.Clear();
nums.Enqueue(1);
nums.Enqueue(2);
nums.Enqueue(3);
nums.Enqueue(4);
nums.Enqueue(5);

while (nums.Count > 0)
{
    Console.WriteLine(nums.Dequeue());
}