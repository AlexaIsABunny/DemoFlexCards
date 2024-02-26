using DemoAlexa.Models;

namespace DemoAlexa.Services
{
    public interface IDeckService
    {
        public List<Deck> GetDecks(string language);
        public Deck GetDeckById(int id);
        public Deck InsertDeck(Deck deck);
    }
}
