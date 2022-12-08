//Make a list of movies 

using DevBuildBlockBuster;

DVD first = new DVD("Star Wars: the good one", Genre.action, 120, "5");

DVD second = new DVD("Remember the Titans", Genre.drama, 150, "5");
DVD third = new DVD("Batman", Genre.comedy, 120, "5");

VHS fourth = new VHS(1, "Superman", Genre.romance, 169, "5");
VHS fifth = new VHS(1, "Spiderman", Genre.horror, 175, "5");
VHS sixth = new VHS(1, "X-Men", Genre.comedy, 110, "5");

List<Movie> movies = new List<Movie>();
movies.Add(first);
movies.Add(second);
movies.Add(third);
movies.Add(fourth);
movies.Add(fifth);
movies.Add(sixth);


BlockBuster allMovies = new BlockBuster(movies);



Console.WriteLine("Welcome to GC Blockbuster!");

Console.WriteLine("Please select a Movie from the list: ");

//This prints the list of the movies 
allMovies.PrintMovies();


//Ask the user if they want to watch the movie
Console.Write("Do you want to watch the movie? (y/n) ");
string userWatch = Console.ReadLine().ToLower();

if (userWatch == "y")
{
    Console.Write($"Which secent of the ");
}