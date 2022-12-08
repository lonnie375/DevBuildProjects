//Create a Movie List 

List<Movie> movieList = new List<Movie>();

//Add 10 movies and there categories here 

//Horror 
movieList.Add(new Movie("The Exorcist", "Horror"));
movieList.Add(new Movie("The Conjuring", "Horror"));

//Action 
movieList.Add(new Movie("Top Gun: Maverick", "Animated"));
movieList.Add(new Movie("The Batman", "Animated"));

//Comedy 
movieList.Add(new Movie("Bullet Train", "Scifi"));
movieList.Add(new Movie("Day Shift", "Scifi"));

//Drama 
movieList.Add(new Movie("Prey", "Drama"));
movieList.Add(new Movie("Elvis", "Drama"));

//Romance 
movieList.Add(new Movie("Titanic", "Romance"));
movieList.Add(new Movie("The Notebook", "Romance"));



Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine();

Console.WriteLine("There are 10 movies in this list");

bool proceed = true;
while (proceed)
{
    Console.Write("What category are you interested in? ");
    string userInput = Console.ReadLine().ToLower();

    
    foreach (Movie movie in movieList)
    {
        
        if (userInput.ToLower() == movie.category.ToLower())
        {

            Console.WriteLine(movie.title);
        }
    }

    Console.Write("Continue? (y/n): ");
    string userContinue = Console.ReadLine().ToLower();

    if (userContinue == "y")
    {

    }
    else
    {
        proceed = false;
        Console.WriteLine("Good");
    }
}










//Class
public class Movie
{
    //Properties/MovieClass members 
    public string title { get; set; }
    public string category { get; set; }

    //Constructor 
    public Movie(string _title, string _category)
    {
        title = _title;
        category = _category;   
    }
}