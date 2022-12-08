Song song1 = new Song("The Beatles", "I want to Hold Your Hand", "Rock", 1964);

List<Song> playList = new List<Song>();
//To Add songs to the list 
playList.Add(song1);

Song song2 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979); 
playList.Add(song2);

Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playList.Add(song3);

Console.WriteLine("Here are your songs: ");

//Loop through the list 
foreach (Song song in playList)
{
    Console.WriteLine(song.title);
}

Console.WriteLine();
Console.Write("Which song do you want more details on: ");
string mySong = Console.ReadLine().ToLower();


 public class Song
{
    public string artist { get; set; }
    public string title { get; set; }
    public string genre { get; set; }
    public int year { get; set; }

    public Song(string _artist, string _title, string _genre, int _year)
    {
        artist = _artist;
        title = _title; 
        genre = _genre; 
        year = _year;   
    }

    public override string ToString()
    {
        return $"{title} by {artist} from {year} {genre}";
    }

   
}

