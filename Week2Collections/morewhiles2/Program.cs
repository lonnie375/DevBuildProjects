string[] names = { "Darren Williams", "Robert Smith", "Mark Powell", "Shawn Miller" };
int[] grades = { 95, 98, 85, 80, 70 };

do
{
	bool okay = false;
	int num = 0; 
	while (!okay)
    {
        Console.WriteLine();
        Console.WriteLine("Please enter a number from 1 to 5.");
		string entry = Console.ReadLine();
		bool validNumber = int.TryParse(entry, out num); 

		if (validNumber)
        {
			if (num >= 1 && num <= 5)
            {
				num--;
				okay = true; 
            }
        }
    }
} while (KeepGoing());





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