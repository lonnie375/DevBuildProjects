

List<Media> mediaList = new List<Media>();
Initialize(mediaList);
    
while (true)
{
    string choice = PrintMenu(mediaList).ToLower();
    //Console.WriteLine(choice);cw      

    if (choice == "a")
    {
        AddNew(mediaList);
    }
    else if (choice == "q")
    {
        // quit
        break; 
    }
    else
    {
        int index = int.Parse(choice) - 1;
        Buy(mediaList, index);
    }
}


//Adds objects to the list => CREATE data into the database 
static void Initialize(List<Media> mediaList)
{
    Video video1 = new Video("The Shining", "horror", "Stanley Kubrik", "R");
    //video1.Play();
    mediaList.Add(video1);

    Digital dig1 = new Digital("The Wall", "rock", "Pink Floyd", 80, "ITunes");
    //dig1.Play();
    mediaList.Add(dig1);
    Vinyl vi1 = new Vinyl("Thriller", "Pop", "Michael Jackson", 90, 1000000);
    //vi1.Play();
    mediaList.Add(vi1);

    dig1 = new Digital("Invisible TOuch", "Rock", "Genesist", 50, "Apple Music");
    mediaList.Add(dig1);

}

//Allows the user to select what they want to buy => DELETES fromt he database
static void Buy(List<Media> mediaList, int index)
{
    Console.WriteLine($"Buying something index {index}");
    Console.WriteLine("Is this the item you want to buy?");
    Console.WriteLine(mediaList[index]);

    Console.Write("(y/n)");
    string yesNo = Console.ReadLine().ToLower();
    
    if (yesNo == "yes" || yesNo == "y")
    {
        mediaList.RemoveAt(index);
    }
    else
    {
        Console.WriteLine("Thanks anyway!"); 
    }
}

//User can add items to the list if it isn't there => CREATES and adds tot he database
static void AddNew(List<Media> theList)
{
    Console.Write("What would you like to add (video/digital/vinyl): ");
    string type = Console.ReadLine().ToLower();
    //Ask for title and genre before media-specific questions. 
    Console.Write("Title: ");
    string title = Console.ReadLine().ToLower();

    Console.Write("Genre: ");
    string genre = Console.ReadLine().ToLower(); 


    if (type == "video")
    {
        Console.Write("Director: ");
        string director  = Console.ReadLine().ToLower();

        Console.Write("Rating: ");
        string rating = Console.ReadLine().ToLower();

        theList.Add(new Video(title, genre, director, rating)); 
    }
    else if (type == "digital")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine().ToLower();

        Console.Write("Duration: ");
        int duration = int.Parse(Console.ReadLine().ToLower());

        Console.Write("Platform: ");
        string platform = Console.ReadLine().ToLower();

        theList.Add(new Digital(title, genre, artist, duration, platform)); 
    }
    else if (type == "vinyl")
    {
        Console.Write("Artist: ");
        string artist = Console.ReadLine().ToLower();

        Console.Write("Duration: ");
        int duration = int.Parse(Console.ReadLine().ToLower());

        Console.Write("Count: ");
        int count = int.Parse(Console.ReadLine().ToLower());

        theList.Add(new Vinyl(title, genre, artist, duration, count)); 
    }
}

//Prints the menu so the user can see their options => READ from the database 
 static string PrintMenu(List<Media> theList)
{
    Console.WriteLine("Choose a media or other option: ");
    for (int i = 0; i < theList.Count; i++)
    {
        //Media med = mediaList[i];
        Console.WriteLine($"{i + 1}: {theList[i]}");
    }

    Console.WriteLine();
    Console.WriteLine("(A)dd new media");
    Console.WriteLine("(Q)uit");
    Console.Write("Your choice: ");
    string entry = Console.ReadLine();
    return entry; 
}




public class Media
{
    public string title { get; set; }
    public string genre    { get; set; }

    public Media(string title, string genre)
    {
        this.title = title;
        this.genre = genre;
    }
    
    public virtual void Play()
    {
        Console.WriteLine("The media is playing.");
    }
}

public class Video : Media
{
    public string director { get; set; }
    public string rating { get; set; }

    public Video(string title, string genre, string director, string rating): base(title, genre)
    {
        this.director = director;
        this.rating = rating;
    }
    
    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Video {title} ({genre}) Directed by {director} Rated {rating}";
    }

}

public class Music : Media
{
    public string artist { get; set; }
    public int duration { get; set; }
    public Music(string title, string genre, string artist, int duration) : base(title,genre)
    {
        this.artist = artist;
        this.duration = duration;
    }

    public override void Play()
    {
        Console.WriteLine($"Music");
    }
}

public class Digital : Music
{
    public string platform { get; set; }
    public Digital(string title, string genre, string artist, int duration, string platform) : base(title, genre, artist, duration)
    {
        this.platform = platform;
    }

    public override void Play()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Digital {title} ({genre}) by {artist}, {duration} minutes on {platform}.";
    }
}

public class Vinyl : Music
{
    public int count { get; set; }

    public Vinyl(string title, string genre, string artist, int duration,int count) :base(title,genre,artist,duration)
    {
        this.count = count;
    }

    public override void Play()
    {
       
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        return $"Vinyl {title} ({genre}) by {artist}, {duration}, {count} limited copies.";
    }
}