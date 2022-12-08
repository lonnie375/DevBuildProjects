//Prompt the user to enter a sentence.  Split the sentence into individual words and display each word on its own line.

bool proceed = true; 
while (proceed){
    Console.Write("Enter a sentence: ");
    string userInput = Console.ReadLine().ToLower();

    string[] breakOut = userInput.Split(" ");

    foreach (string line in breakOut)
    {
        Console.WriteLine(line);
    }

    Console.Write("Would you like to continue (y/n)? ");
    string userResponse = Console.ReadLine().ToLower(); 

    if (userResponse == "y")
    {

    }
    else
    {
        Console.WriteLine("GoodBye!");
        proceed = false;
    }
}

