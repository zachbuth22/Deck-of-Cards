using System;
namespace Draw5.Models
{
        public partial class Draw5Model
        {
            public bool Success { get; set; }
            public string DeckId { get; set; }
            public List<Card> Cards { get; set; }
            public long Remaining { get; set; }
        }

        public partial class Card
        {
            public string Code { get; set; }
            public Uri Image { get; set; }
            public Images Images { get; set; }
            public long Value { get; set; }
            public string Suit { get; set; }
        }

        public partial class Images
        {
            public Uri Svg { get; set; }
            public Uri Png { get; set; }
        }

}

