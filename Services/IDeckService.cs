using DemoAlexa.Models;

namespace DemoAlexa.Services
{
    public interface IDeckService
    {
        public List<Deck> GetDecks();
        public Deck GetDeckById(int id);
        public Deck InsertDeck(Deck deck);
    }
}
