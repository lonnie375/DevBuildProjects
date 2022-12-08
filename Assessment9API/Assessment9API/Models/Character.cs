namespace Assessment9API.Models
{
    public class Character
    {
        public string name { get; set; }    
        public string gender { get; set; }

        public List<string> playedBy { get; set; }

    }

    public class MyList
    {
        public List<Character> list { get; set; }   

        public MyList()
        {
            list = new List<Character>();
        }
    } 


    //DAL with method here 

    public class CharacterAPI
    {
           public static HttpClient _web = null; 
            
            public static HttpClient GetHttpClient()
            {
                if (_web == null)
                {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://anapioficeandfire.com/api/");
                }
                return _web;
            }
     
        public async static Task<MyList> GetSpecificCharacter()
        {
            HttpClient web = GetHttpClient();   
            var connection = await web.GetAsync($"characters/823");
            Character chars1 = await connection.Content.ReadAsAsync<Character>();

            var connection2 = await web.GetAsync($"characters/2");
            Character chars2 = await connection2.Content.ReadAsAsync<Character>();

            var connection3 = await web.GetAsync($"characters/216");
            Character chars3 = await connection3.Content.ReadAsAsync<Character>();

            var connection4 = await web.GetAsync($"characters/217");
            Character chars4 = await connection4.Content.ReadAsAsync<Character>();
            var connection5 = await web.GetAsync($"characters/400");
            Character chars5 = await connection5.Content.ReadAsAsync<Character>();

            //Add to your list of characters 
            MyList myList = new MyList();
            myList.list.Add(chars1);
            myList.list.Add(chars2);
            myList.list.Add(chars3);
            myList.list.Add(chars4);
            myList.list.Add(chars5);

            return myList; 


        }
    }
}
