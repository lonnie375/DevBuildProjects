string sentence = "";
string word = "";
string wordUsage = word;
int count = 0;
do
{
    bool valid = false;
   

    while (!valid)
    {
        Console.Write("Please enter a sentence: ");
        sentence = Console.ReadLine();
        if (sentence.Contains(" "))
        {
            valid = true;
        }
        else
        {
            Console.WriteLine("Make sure your sentence contains at least one space.");
        }
    }


    valid = false;
    while (!valid)
    {
        Console.WriteLine("Please enter a word: ");
        word = Console.ReadLine();

        if (word.Contains(" "))
        {
            Console.WriteLine("Make sure you only enter a single word with no spaces");
        }
        else
        {
            valid = true;
        }
    }

    bool contains = sentence.ToLower().Contains(word.ToLower());
   
    if (contains)
    {
        Console.WriteLine("Yup, that word exists in the sentence.");
    }
    else
    {
        Console.WriteLine("Nope, that word isn't found in the sentence.");
    }

    if(sentence.Contains(word) == true)
    {
        count++; 
    }

}while(KeepGoing());
static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
} 