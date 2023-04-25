namespace yugioh_card_search.Models
{
    public partial class CardModel
    {
        public class Card_Prices
        {
            public string cardmarket_price { get; set; }
            public string tcgplayer_price { get; set; }
            public string ebay_price { get; set; }
            public string amazon_price { get; set; }
            public string coolstuffinc_price { get; set; }
        }

    }
}
