//Prompt the user to enter a series of words.  Once the user is done entering the words, output a sentence containing all the words.
bool proceed = true;
List<string> userWords = new List<string>();
while (proceed)
{
    
    Console.Write("Enter a word: ");
    string input = Console.ReadLine().ToLower();
    userWords.Add(input);

    Console.Write("Would you like to enter another word (y/n)? ");
    string userInput = Console.ReadLine().ToLower();
   
    if (userInput == "y" || userInput == "yes")
    {

    }
    else if (userInput == "n" || userInput == "no")
    {
        foreach (string word in userWords)
        {
            Console.Write($"{word} ");
            
        }
        Console.Write("Would you like to continue? (y/n) ");
        string userChoice = Console.ReadLine().ToLower();
        if (userChoice == "y" || userChoice == "yes")
        {
            proceed = true;
            userWords.Clear(); 
        }
        else
        {
            Console.WriteLine("GoodBye!");
            proceed = false; 
        }
    }

    
}
