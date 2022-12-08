//Create two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. Fill the second array with the strings:
//"Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking".
//Combine both arrays to display a piece of the holiday song.

int[] numbersArray = { 12, 11, 10, 9, 8 };

string[] drummerArray = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

Console.Write("Enter a command (sing/quit): "); 
string input = Console.ReadLine();  

if (input == "sing")
{
    for (int i = 0; i < numbersArray.Length; i++)
    {
        Console.WriteLine("{0}, {1}", numbersArray[i],drummerArray[i]);
    }
    
}