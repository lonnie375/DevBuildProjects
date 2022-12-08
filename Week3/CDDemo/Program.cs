//Compact Disc 

CompactDisc worshipMusic = new CompactDisc("Pink Floyd", "Rock", 80);
Console.WriteLine(worshipMusic);

worshipMusic.songs.Add("In the Flesh");
worshipMusic.songs.Add("The Thin Ice");
worshipMusic.songs.Add("ANother Brick In The Wall");
worshipMusic.songs.Add("The Happiest Days In Our Lives");
worshipMusic.songs.Add("Another Brick In The Wall, Part 2"); 

//Loop through the songs 
foreach(string song in worshipMusic.songs)
{
    Console.WriteLine(song);
}

Console.WriteLine($"This album has {worshipMusic.SongCount()} songs.");

//Lets practice copying 
//We have the same object referenced by two variables 

CompactDisc another = worshipMusic;

Console.WriteLine(another.artist);
public class CompactDisc
{
   public string artist { get; set; }
   public string genre { get; set; }
   public int duration { get; set; }
    public List<string> songs { get; set; }
   
   public CompactDisc(string artist, string genre, int duration)
    {
        this.artist = artist;
        this.genre = genre;
        this.duration = duration;
        //This is how we create a list 
        songs = new List<string>();
     
    }
    public CompactDisc()
    {
    }

    public int SongCount()
    {
        return songs.Count; 
    }
    public override string ToString()
    {
        return $"Artist: {artist}  Genre: {genre}  Duration: {duration} minutes"; 
    }
}