using DemoAlexa.Models;

namespace DemoAlexa.Services
{
    public class DeckService : IDeckService
    {
        private List<Deck> _decks;
        //public List<Deck> Decks;

        public DeckService()
        {
            _decks = new List<Deck>()
            {
                new Deck()
                {
                    Id = 1,
                    Name = "Kleuren",
                    Description = "Kleuren leren van Frans naar Nederlands",
                    Language = "RU"
                },
                new Deck()
                {
                    Id = 2,
                    Name = "Russisch",
                    Description = "Russische decks",
                    Language = "RU",
                },
            };
        }

        public List<Deck> GetDecks(string language)
        {
            return _decks
                .Where(x => x.Language == language).ToList()
                ;
        }

        public Deck GetDeckById(int id)
        {
            return _decks.FirstOrDefault(x => x.Id == id);
        }

        public Deck InsertDeck(Deck deck)
        {
            deck.Id = _decks.Max(x => x.Id) + 1;
            _decks.Add(deck);
            return deck;
        }
    }
}
