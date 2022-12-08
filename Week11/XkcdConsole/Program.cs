//https://xkcd.com/info.0.json

Console.WriteLine("WHich comic number would you like to see?");
string entry = Console.ReadLine();

HttpClient web = new HttpClient(); //Opens the connection 
web.BaseAddress = new Uri("https://xkcd.com/"); //Connects us to the website 
var connection = await web.GetAsync($"{entry}/info.0.json"); //Gets information
string result = await connection.Content.ReadAsStringAsync(); //Returns information 
//Console.WriteLine(result);


try
{
    Comic com = await connection.Content.ReadAsAsync<Comic>();
    Console.WriteLine(com.alt);
    Console.WriteLine(com.img);
}
catch (Exception ex)
{
    Console.WriteLine("Sorry, That doesn't exist.");
}


class Comic
{
    public int month { get; set; }
    public int num { get; set; }
    public string link { get; set; }
    public int year { get; set; }
    public string news { get; set; }
    public string safe_title { get; set; }
    public string transcript { get; set; }
    public string alt { get; set; }
    public string img { get; set; }
    public string title { get; set; }
    public int day { get; set; }

}
