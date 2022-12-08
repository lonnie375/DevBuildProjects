using MyVersionOfDevBuildRockPaperScissors;

RandomPlayer player1 = new RandomPlayer("Ryan");

AlwaysPlayer player2 = new AlwaysPlayer("Stacey", Roshambo.rock);

AlwaysPlayer player3 = new AlwaysPlayer("Sherry", Roshambo.scissors);

RandomPlayer player4 = new RandomPlayer("Keith"); 

Play(player1, player2);
Console.WriteLine();
Play(player1, player3);
Console.WriteLine();
Play(player1, player4);
Console.WriteLine();
Play(player2, player3);
Console.WriteLine();
Play(player2, player4);
Console.WriteLine();

static void Play(Player player1, Player player2)
{
    player1.Generate();
    player2.Generate();

    string winner = " "; 
    if (player1.CurrentChoice == player2.CurrentChoice)
    {
        winner = "No one wins, it's a draw.";
    }
    else if (player1.CurrentChoice == Roshambo.scissors && player2.CurrentChoice == Roshambo.paper)
    {
        winner = player1.Name; 
    }
    else if (player1.CurrentChoice == Roshambo.scissors && player2.CurrentChoice == Roshambo.rock)
    {
        winner = player2.Name;
    }
    else if (player1.CurrentChoice == Roshambo.rock && player2.CurrentChoice == Roshambo.paper)
    {
        winner = player2.Name;
    }
    else if (player1.CurrentChoice == Roshambo.rock && player2.CurrentChoice == Roshambo.scissors)
    {
        winner = player1.Name; 
    }
    else if (player1.CurrentChoice == Roshambo.paper && player2.CurrentChoice == Roshambo.rock)
    {
        winner = player1.Name;
    }
    else if (player1.CurrentChoice == Roshambo.paper && player2.CurrentChoice == Roshambo.scissors)
    {
        winner = player2.Name; 
    }

    Console.WriteLine($"{player1.Name} played {player1.CurrentChoice} and {player2.Name} played {player2.CurrentChoice}. The winner is {winner}.");
}


public enum Roshambo
{
    rock, 
    paper, 
    scissors 
}