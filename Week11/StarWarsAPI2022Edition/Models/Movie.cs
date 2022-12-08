namespace StarWarsAPI2022Edition.Models
{
    public class Movie
    {
        //This is used to store film information 
        public string title { get; set; } //name of the movie 
        public int year { get; set; }
        public List<string> names { get; set; }
        public List<string> starships { get; set; }


    }
}
