namespace PokerGame.Models
{
    public class PokerHands
    {
        public Hand player1 { get; set; }
        public Hand player2 { get; set; }
        public string deckId { get; set; }
        public Hand winner
        {
            get
            {
                if (player1.value == player2.value)
                {
                    return player1;
                } else
                {
                    return player2; 
                }
            }
        }
    }
    public class Hand
    {
        public string username { get; set; }
        public List<Card> cards { get; set; }
        /*
         * Rankings
         *      Hearts = 4, Spades = 3, Diamonds = 2, Clubs = 1
         *      Cards will just have their 2 through 13 rank 
         *      And we'll multiply suit value by card value
         */
        public int value
        {
            get
            {
                int max = 0;
                foreach(Card card in cards)
                {
                    if (card.value > max)
                    {
                        max = card.value;   
                    }
                }
                return max; 
            }

            
        }  // Come back tot his to fill in the getter 

        public Hand()
        {
            cards = new List<Card>();
        }   
    }

    public class Card
    {
        public string suit { get; set; }
        public int rank { get; set; } //2,3,....9 J=10, Q=11,K12, A=13
        public string image { get; set; }
        public int value { 
            
            get
            {
                int suitValue = 0;
                if (suit == "H")
                {
                    suitValue = 4; 
                } else if (suit == "S")
                {
                    suitValue = 3;
                } else if (suit == "D")
                {
                    suitValue = 2; 
                } else if (suit == "C")
                {
                    suitValue = 1; 
                }
                return suitValue * 14 + rank; 
             }
            }  

    }
}
