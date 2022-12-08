//Ask the user for a word 
//Create a method to reverse the word/string the user provided 
//Inside of the reverse method use a stack to reverse the string
//Instantiate the stack 
//Add to the stack 
//Retrieve the stack items in reverse order
//Display the reversed string in the console 


using System.Collections;
using System.Collections.Generic;

Console.Write("Please enter a word you would like to reverse: ");
string userInput = Console.ReadLine();

Console.Write("Please enter a sentence where you would like the words reversed: ");
string wordInput = Console.ReadLine();  

Console.WriteLine($"Your word in reverse is : {ReverseString(userInput)}");

Console.WriteLine($"The words have been reversed in your sentence: {ReverseWordOnly(wordInput)}");





//Reverse Method 
static string ReverseString(string userInput)
{
    
    //Create a variable that we are going to store the reverse string inside of
    
    var inputReversed = ""; 

    //Create an instance of stack so that we can add the string o 
    Stack stack = new Stack();

    //Filter through all of the characters in the users string and add them to stack
    foreach(var user in userInput)
    {
        stack.Push(user); 
    }

    //We want to make sure the user has entered a string
    //We are storing the items that we are removing in the new variable. 
    //Stack is first in first out so the information will be printed backwards

    while(stack.Count > 0)
    {
        
        inputReversed += stack.Pop();
    }
    return inputReversed;
}




//reverse words 
static string ReverseWordOnly(string userInput)
{
    string reverseWord = string.Join(" ", userInput.Split(' ').Select(x => new string(x.Reverse().ToArray())));
    
    return reverseWord; 
}


