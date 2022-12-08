
//Section 1: Create and populate the list of songs


Song song1 = new Song("The Beatles", "I want to Hold Your Hand", "Rock", 1964);

List<Song> playList = new List<Song>();

//To Add songs to the list 
playList.Add(song1);

//We don't need to create a new variable after we put the object in the list.
song1 = new Song("Pink Floyd", "Comfortably Numb", "Progressive", 1979); 
playList.Add(song1);

song1 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playList.Add(song1);

//Not storing an object, we are just handing it over to the list. 
//We actually don't need a variable at all. 

playList.Add(new Song("Dave Brubeck", "Take 5", "Jazz", 1959));


// Section 2: Print out the titles


Console.WriteLine("Here is your playlist: ");

foreach( Song song2 in playList)
{
    Console.Write(song2.artist);
    Console.WriteLine(song2.title);
    
}



// Section 3: Ask the user for a song and print out the details 

Console.Write("Which song title do you want more info on: ");
string mySong = Console.ReadLine();

Song found = FindSong(playList, mySong); 

//foreach (Song song2 in playList)
//{
//    if (song2.title.ToLower() == mySong)
//    {
//        found = song2;
//        break; 
//    }
   
//}
if (found == null)
{
    Console.WriteLine("Sorry we don't have that song");
}
else
{
    Console.WriteLine(found);
}

//Section 4: A helper method was created to help execute the details 


static Song FindSong(List<Song>theList, string theTitle)
{
    Song found = null; 
    foreach(Song next in theList)
    {
        if (next.title.ToLower() == theTitle.ToLower())
        {
            return next; 
        }
        
    }
    return null;
}

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

