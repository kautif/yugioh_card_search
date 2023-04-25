namespace yugioh_card_search.Models
{
    public partial class CardModel
    {
        public class Card_Images
        {
            public int id { get; set; }
            public string image_url { get; set; }
            public string image_url_small { get; set; }
            public string image_url_cropped { get; set; }
        }

    }
}
