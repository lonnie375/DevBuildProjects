//1. Create an initial collection of items to stock in the inventory, with the following starter items 
List<string> inventoryList = new List<string>();
inventoryList.Add("broccoli");
inventoryList.Add("tomatoes");
inventoryList.Add("zucchini");



//2. Present the user with a menu of the following options 
Dictionary<int, string> menu = new Dictionary<int, string>();
menu.Add(1, "Add Items");
menu.Add(2, "Remove an Item");
menu.Add(3, "View Inventory");


foreach (KeyValuePair<int, string> menuList in menu)
{
    Console.Write("[{0}] {1}: ", menuList.Key, menuList.Value);
}
Console.WriteLine();

bool proceed = true;
while (proceed)
{

    Console.WriteLine("Please enter 1, 2, or 3: ");


    string userInput = Console.ReadLine();
    int inventorySelection;
    bool correct = int.TryParse(userInput, out inventorySelection);

    //Error handling 1
    //Make sure that the user enters a integer
    if (correct && inventorySelection == 1 || inventorySelection == 2 || inventorySelection == 3)
    {

    }
    else
    {
        continue;
    }




    //3. Add Items 
    if (inventorySelection == 1)
    {
        Console.WriteLine("Number of items to add: ");
        string userInventory = Console.ReadLine();
        int addInventory;
        bool correction = int.TryParse(userInventory, out addInventory);

        int prompt = 0;
        if (correction)
        {

        }
        else
        {
            Console.Write("Please enter a integer: ");
        }

        while (addInventory != prompt)
        {
            Console.Write("item: ");
            prompt++;
            string listItem = Console.ReadLine().ToLower();
            inventoryList.Add(listItem);

        }



    }

    //4. Remove items 
    else if (inventorySelection == 2)
    {
        bool removeItem = true;
        while (removeItem)
        {
            Console.WriteLine("Item to remove:? ");
            string userRemove = Console.ReadLine().ToLower();

            inventoryList.Remove(userRemove);
            Console.WriteLine($"Thank you your {userRemove} has been removed from the list.");


            Console.WriteLine("Would you like to remove another item? (y/n)");
            string removeAdd = Console.ReadLine().ToLower();

            if (removeAdd == "y")
            {

            }
            else
            {
                removeItem = false;
            }
        }
    }
    //5. View inventory 
    else if (inventorySelection == 3)
    {
        int counter = 1;
        foreach (string item in inventoryList)
        {
            Console.WriteLine("{0}: {1} ", counter, item);
            counter++;
        }
    }


    Console.WriteLine("Return to the menu (y/n): ");
    string userReturn = Console.ReadLine().ToLower();

    //Error Handling part 2
    bool correctInput = false;
    while (correctInput == false)
    {
        if (userReturn == "y")
        {
            correctInput = true;
            foreach (KeyValuePair<int, string> menuList in menu)
            {
                Console.Write("[{0}] {1}: ", menuList.Key, menuList.Value);
            }
        }
        else if (userReturn == "n")
        {
            correctInput = true;
            Console.WriteLine("Thank you, GoodBye!");
            proceed = false;
        }
        else
        {
            Console.WriteLine("Please enter 'y' or 'n': ");
            userReturn = Console.ReadLine().ToLower();

        }
    }
}
