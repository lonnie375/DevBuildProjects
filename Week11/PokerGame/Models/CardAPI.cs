namespace PokerGame.Models
{
    public class CardResponse
    {
        public bool success { get; set; }
        public string deck_id { get; set; }
        public List<APICard> cards { get; set; }
        public int remaining { get; set; }
    }

    public class APICard
    {
        public string code { get; set; }
        public string image { get; set; }
        public string value { get; set; }
        public string suit { get; set; }
    }

    public class CardAPI
    { 
        //
        // CardAPI functionality 
        // GetDeck() = return a Deck ID
        // GetHand(deck_id, count) - return a single Hand instance 
        // with the Card list all populated. 
        //
        public static HttpClient _web = null;
        public static HttpClient GetHttpClient()
        {   // We call this concept a "singleton"

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

        public async static Task<Hand> GetHand(string deck_id, int count)
        {
            HttpClient web = GetHttpClient();
            var connection = await web.GetAsync($"{deck_id}/draw/?count={count}");
            CardResponse resp = await connection.Content.ReadAsAsync<CardResponse>();

            // INstead of just returning CardReponse instance, we'll 
            // create an instance of Hand and fill it, and return that 
            Hand newHand = new Hand();

            foreach(APICard apicard in resp.cards)
            {
                Card newcard = new Card();
                newcard.image = apicard.image;
                newcard.suit = apicard.suit.Substring(0,1);
                int cardvalue = 0; 
                bool worked = int.TryParse(apicard.value, out cardvalue); 
                //if it's not a number because it's not then it will execute the code below
                // and we will assign values 
                // The numbers will be converted to ints and have their appropriate numbers!!!
                if (!worked)
                {
                    if (apicard.value == "JACK")
                    {
                        cardvalue = 11; 
                    } else if (apicard.value == "QUEEN")
                    {
                        cardvalue = 12; 

                    } else if (apicard.value == "KING")
                    {
                        cardvalue = 13; 
                    } else if (apicard.value == "Ace")
                    {
                        cardvalue = 14; 
                    }
                }
                newcard.rank = cardvalue; 
                newHand.cards.Add(newcard);
            }
            return newHand; 
        }
    }
}
