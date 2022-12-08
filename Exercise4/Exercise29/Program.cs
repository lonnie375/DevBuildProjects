//Prompt the user to enter text.  Remove all the vowels in the middle of the word, but leave any that start or end the word.


    string vowels = "aeiou";
    Console.Write("Enter some text: ");
    string input = Console.ReadLine().ToLower();

    string[] userInput = input.Split(", ");
    string vowelsRemved = ""; 

    foreach(string newWord in userInput)
    {
        for (int i = 0; i < newWord.Length; i++)
        {
            if (i == 0 || i == newWord.Length - 1)
            {
                vowelsRemved += newWord[i];
            }
            else if (!vowels.Contains(newWord[i]))
            {
                vowelsRemved += newWord[i];
            }
        }
        vowelsRemved += " "; 
    }
    Console.WriteLine(vowelsRemved);

//    Console.WriteLine($"{userInput}");

//    Console.Write("Would you like to continue (y/n)? ");
//    string userChoice = Console.ReadLine().ToLower();

//    if (userChoice == "y")
//    {

//    }
//    else
//    {
//        Console.WriteLine("GoodBye");
//        proceed = false;
//    }
//}