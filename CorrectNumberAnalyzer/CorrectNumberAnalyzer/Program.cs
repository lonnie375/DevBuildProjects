Console.Write("Please provide your name before we begin: ");

string userName = Console.ReadLine().ToLower();



bool end = false;



while (end == false)



{



    Console.Write("Please provide an integer between 1 and 100: ");

    string input = Console.ReadLine();

    int userNumber;

    bool correctInput = int.TryParse(input, out userNumber);







    if (correctInput && userNumber >= 1 && userNumber <= 100)

    {



    }

    else

    {

        while (correctInput == false || userNumber < 1 || userNumber > 100)

        {

            Console.Write("Please enter an number between 1 and 100: ");

            input = Console.ReadLine();

            bool correctOutput = int.TryParse(input, out userNumber);



            if (correctOutput && userNumber >= 1 && userNumber <= 100)

            {

                correctInput = true;

            }

        }



    }





    if (userNumber % 2 != 0 && userNumber >= 1 && userNumber < 60)

    {

        Console.WriteLine("Odd and less than 60.");

    }

    else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)

    {

        Console.WriteLine("Even and less than 25.");

    }

    else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)

    {

        Console.WriteLine("Even and between 26 and 60 inclusive.");

    }

    else if (userNumber % 2 == 0 && userNumber > 60 && userNumber <= 100)

    {

        Console.WriteLine("Even and greater than 60");

    }

    else if (userNumber % 2 != 0 && userNumber > 60 && userNumber <= 100)

    {

        Console.WriteLine("Odd and greater than 60");

    }





    Console.Write($"{userName}, would you like to continue. If so, please enter yes(y) or no(n).");

    string userResponse = Console.ReadLine().ToLower();



    if (userResponse == "yes" || userResponse == "y")

    {

        end = false;

    }

    else

    {

        Console.WriteLine("Good Bye!");

        end = true;



    }



}

