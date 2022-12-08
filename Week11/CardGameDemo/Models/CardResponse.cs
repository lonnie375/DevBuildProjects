namespace CardGameDemo.Models
{
   

    public class CardResponse
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public List<Card> cards { get; set; }
        public int remaining { get; set; }
    }

    public class Card
    {
        public string code { get; set; }
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
    }
    //This is called encapsulation so that we don't have to continually write httpclient 
    public class CardAPI
    {
        //We will have two methods 
        // GetNewDeck()
        // GetCards() 

        //DO Not access this variable directly! when you need 
        // an httpclient instance, call GetHttpClient(). 
        public static HttpClient _web = null; 
        
        public static HttpClient GetHttpClient()
        {   // We call this concept a "singleton"


            // FIrst see if we already have an HttpClient 
            // If so, return that one, 
            // Else create one and return that one. 
            // or, flip the logic 
            // 
            // first see if we already have an HttpClient
            // If not, create one
            // Then regardless, return it

            if (_web == null)
            {
                _web = new HttpClient();
                _web.BaseAddress = new Uri("https://www.deckofcardsapi.com/api/deck/");
            }

      
            return _web; 
        }
        public async static Task<string> GetNewDeck()
        {
            HttpClient web = GetHttpClient();
            var connection = await web.GetAsync($"new/shuffle/?deck_count=1");
            CardResponse resp = await connection.Content.ReadAsAsync<CardResponse>();
            return resp.deck_id; 
        }

     

        public async static Task<CardResponse> GetCards(string deck_id, int count)
        {
            HttpClient web = GetHttpClient();
            var connection = await web.GetAsync($"{deck_id}/draw/?count={count}");
            CardResponse resp = await connection.Content.ReadAsAsync<CardResponse>();
            return resp; 
        }
    }
}
