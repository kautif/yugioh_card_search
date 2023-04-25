namespace yugioh_card_search.Models
{
    public partial class CardModel
    {
        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string frameType { get; set; }
            public string desc { get; set; }
            public string race { get; set; }
            public Card_Sets[] card_sets { get; set; }
            public Card_Images[] card_images { get; set; }
            public Card_Prices[] card_prices { get; set; }
            public int atk { get; set; }
            public int def { get; set; }
            public int level { get; set; }
            public string attribute { get; set; }
            public string archetype { get; set; }
            public int scale { get; set; }
            public int linkval { get; set; }
            public string[] linkmarkers { get; set; }
            public Banlist_Info banlist_info { get; set; }
        }

    }
}
