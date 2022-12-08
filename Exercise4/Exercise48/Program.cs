//Prompt the user to enter as many numbers as she wants.  Store these numbers in a list and output their sum.
//How to stop sum from being added after the loop is done

List<int> userNumbers = new List<int>();
int sum = 0;
bool proceed = true;
while (proceed)
{
    
    Console.Write("Enter a number (q to quit): ");
    string userNumber = (Console.ReadLine().ToLower());

    if (userNumber == "q")
    {
       
        foreach (int i in userNumbers)
        {
            sum += i;
            Console.Write(string.Format("{0}", i));
            
        }
        Console.WriteLine($"Total is {sum}");
        
        Console.Write("Would you like to continue (y/n)? ");
        string userContinue = Console.ReadLine();

        

        if (userContinue == "y")
        {
            sum = 0;
        }
        else
        {
            proceed = false;
            Console.WriteLine("GoodBye!");
        }
        
           
        

    }
   
        if (userNumber != "q")
    {
         int newNumber = Convert.ToInt32(userNumber);    
    userNumbers.Add(newNumber);

    }


    

}