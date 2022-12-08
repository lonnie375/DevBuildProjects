
using DevBuildRockPaperScissors;

RandomPlayer player1 = new RandomPlayer("Roger");

AlwaysPlayer player2 = new AlwaysPlayer("Sally", Roshambo.rock); 

AlwaysPlayer player3 = new AlwaysPlayer("Same", Roshambo.paper);

RandomPlayer player4 = new RandomPlayer("Jim");

Play(player1, player2);
Console.WriteLine();
Play(player1, player2);
Console.WriteLine();
Play(player1, player2);
Console.WriteLine();
Play(player1, player3);
Console.WriteLine();
Play(player1, player3);
Console.WriteLine();
Play(player1, player3);
Console.WriteLine();
Play(player1, player4);
Console.WriteLine();
Play(player1, player4);
Console.WriteLine();
Play(player1, player4);
Console.WriteLine();
Play(player2, player4);
Console.WriteLine();
Play(player3, player4);

////Practice for Random 
//Random rnd = new Random();
//int num = rnd.Next(0, 7);

////We have to cast by adding Roashambo in parenthesis. 
//Roshambo r1 = (Roshambo)rnd.Next(0, 3);


//This is an example of polymorphism: We're calling the respective Generate function based on the class. 
static void Play(Player one, Player two)
{
    one.Generate();
    two.Generate();

    string winner = " ";
    if (one.CurrentChoice == two.CurrentChoice)
    {
        //Console.WriteLine($"Players: {one.Name} and {two.Name}. Result: Draw");
        winner = "Nobody";
    }
    else if (one.CurrentChoice == Roshambo.rock)
    {
        if (two.CurrentChoice == Roshambo.paper)
        {
            winner = two.Name; 
        }
        else // two is playing scissors
        {
            // rock beats scissors, player one wins 
            winner = one.Name;
        }

    }
    else if (one.CurrentChoice == Roshambo.paper)
    {
        if (two.CurrentChoice == Roshambo.rock)
        {
            // paper beats Rock 
            winner = one.Name; 
        }
        else // two must be scissors 
        {
            // Scissors beats paper so player two wins 
            winner = two.Name; 
        }
    }
    else // p1 is playing scissors 
    {
        if (two.CurrentChoice == Roshambo.rock)
        {
            // rock wins 
            winner = two.Name; 
        }
        else // must be paper 
        {
            // scisoors beat paper -- player one wins 
            winner = one.Name; 
        }
    }
    Console.WriteLine($"Players: {one.Name} played {one.CurrentChoice} and {two.Name} played {two.CurrentChoice}. Result: {winner} wins!");
}

//Console.WriteLine(r1);
// 1. Create an enum 
public enum Roshambo
{
    rock, 
    paper, 
    scissors
  
}

