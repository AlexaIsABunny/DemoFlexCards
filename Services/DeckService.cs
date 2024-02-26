using DemoAlexa.Models;
using System.Data;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace DemoAlexa.Services
{
    public class DeckService : IDeckService
    {
        private List<Deck>? _decks;
        private string path = "C:\\data\\Flexcards\\db.json";
        //public List<Deck> Decks;

        public DeckService()
        {
            //_decks = new List<Deck>()
            //{
            //    new Deck()
            //    {
            //        Id = 1,
            //        Name = "Kleuren",
            //        Description = "Kleuren leren van Frans naar Nederlands",
            //        Language = "RU"
            //    },
            //    new Deck()
            //    {
            //        Id = 2,
            //        Name = "Russisch",
            //        Description = "Russische decks",
            //        Language = "RU",
            //    },
            //};

            if (File.Exists(path))
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    if (json != null && json != string.Empty)
                    {
                        _decks = JsonSerializer.Deserialize<List<Deck>>(json);
                    }
                    else
                    {
                        _decks = new();
                    }
                }
            }
            else
            {

            }

            //var json = JsonSerializer.Serialize(_decks);
        }

        private void Update()
        {
            var json = JsonSerializer.Serialize(_decks);
            File.WriteAllText(path, json);
        }

        public List<Deck> GetDecks(string language)
        {
            return _decks
                .Where(x => x.Language == language).ToList();
            Update();
        }

        public Deck GetDeckById(int id)
        {
            return _decks.FirstOrDefault(x => x.Id == id);
            Update();
        }

        public Deck InsertDeck(Deck deck)
        {
            deck.Id = _decks.Count == 0 ? 0 :_decks.Max(x => x.Id) + 1;
            _decks.Add(deck);
            Update();
            return deck;
        }
    }
}
