//Prompt the user to enter a language. Based on the language the uer input, display "hello,World!" in that language. Use a switch statement to choose what to display 



Console.Write("Enter a langugage: ");
string input = Console.ReadLine().ToLower();  

switch (input)
{
    case "english":
        Console.WriteLine("Hello, World!");
        break;
    case "spanish":
        Console.WriteLine("Hola Mundo");
        break;
    case "dutch":
        Console.WriteLine("Hallo Wereld");
        break; 
    default:
        Console.WriteLine("Goodbye");
        break; 
}