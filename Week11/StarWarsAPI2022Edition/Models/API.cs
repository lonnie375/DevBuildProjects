namespace StarWarsAPI2022Edition.Models
{
        public class FilmResponse
        {
            public string title { get; set; }
            public string release_date { get; set; }
            public List<string> characters { get; set; }
            public List<string> starships { get; set; }
           

        }


        public class PersonResponse
        {
            public string name { get; set; }
           

        }

        public class StarshipResponse
        {
            public string name { get; set; }
        }

        //DAL will start here
        public class StarWarsAPI
        {
            public static HttpClient _web = null; 
            
            public static HttpClient GetHttpClient()
            {
                if (_web == null)
                {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://swapi.dev/api/");
                }
                return _web;
            }
            
            //Find Movie 
            public async static Task<Movie> FindMovie(int filmnum)
            {

                HttpClient web = GetHttpClient();
                var connection = await web.GetAsync($"films/{filmnum}"); //Connecting to the API
                FilmResponse resp = await connection.Content.ReadAsAsync<FilmResponse>(); //Retrieving the information from
                                                                                          //FilmResponse that the API has

                Movie mymovie = new Movie(); //Our single instance of movie 
                                             //This is needed for us to store the details 
                                             //title, name, starship, etc 

                mymovie.names = new List<string>(); //Initialize the lists 
                mymovie.starships = new List<string>(); //We could have done this in our constructor as well
                                                        //The constructor wouldn't have any parameters
                                                        //Just the property name and the new List information 

                mymovie.title = resp.title; //grab the title 
                mymovie.year = int.Parse(resp.release_date.Substring(0, 4)); //grabing just the year here
                                                                             //and converting this to an int!

                //Fill in string lists 
                //  Fill in characert or PERSON 
                foreach(string url in resp.characters) //we are grabbing the characters in Film!!
                {
                    //url has the full UL as in 
                    //But we really just want the last part of it. 
                    
                 connection = await web.GetAsync(url);
                 PersonResponse presp = await connection.Content.ReadAsAsync<PersonResponse>(); //GIves us back the character profile. We only need the name 
                //Add the check here to get all persons 
                mymovie.names.Add(presp.name); //Adding the name to the string list 
                    
                }
                
                //  Fill in Starship names 
                foreach(string url in resp.starships) //We are grabbing the starships in Film
                {
                connection = await web.GetAsync(url);
                StarshipResponse presp = await connection.Content.ReadAsAsync<StarshipResponse>();
                mymovie.starships.Add(presp.name);
                }

                return mymovie;
            
            }


        
        }
}
