using DemoAlexa.Models;
using DemoAlexa.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoAlexa.Models;

namespace DemoAlexa.Pages.Decks
{
    public class DeckModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDeckService _deckService;

        public Deck Deck { get; set; }

        public DeckModel(ILogger<IndexModel> logger, IDeckService deckService)
        {
            _logger = logger;
            _deckService = deckService;
        }
        public void OnGet(int deckId)
        {
            Deck = _deckService.GetDeckById(deckId);
        }
    }
}
