Digital music1 = new Digital("The Wall", "Pink Floyd", "Itunes");

Vinyl vinyl = new Vinyl("Sgt. Peppers Lonely Hearts Club Band", "The Beatles", 1000); 

List<Music> songs = new List<Music>();

songs.Add(music1); 
songs.Add(vinyl);

music1.Print();
vinyl.Print();

// By addig abstract we ar eblocking anyone from creating an instance of Music. 
// We can still make instances of classes derived from music 
// We can still use the Music type in our lists 

abstract class Music
{
    public string Title { get; set; }
    public string Artist { get; set; }  
    public Music(string title, string artist)
    {
        Title = title;
        Artist = artist;
    }

    // Virtual functions should be shorthanded like this. 
    // We leave this blank because it will never get called. 
    // This is only placed here as a placeholder for the classes that will inherit it. 
    // We changed this from virtual to abstract and removed the curly braces. 
    public abstract void Print(); 

    //public virtual void Print()
    //{

    //}
}

 class Digital : Music
{
    public string Platform { get; set; }

    public Digital(string artist, string title, string platform) : base(title, artist)
    {
        Platform = platform;
    }

    public override void Print()
    {
        Console.WriteLine("This is a digital album!");
    }
}

 sealed class Vinyl : Music
{
    public int Count { get; set; }

    public Vinyl(string artist, string title, int count ) : base(title, artist)
    {
        Count = count;
    }
    public override void Print()
    {
        Console.WriteLine("THis is a vinyl album!");
    }
}