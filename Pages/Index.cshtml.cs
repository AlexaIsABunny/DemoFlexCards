using DemoAlexa.Models;
using DemoAlexa.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAlexa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDeckService _deckService;

        public List<Deck> Decks { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IDeckService deckService)
        {
            _logger = logger;
            _deckService = deckService;
        }

        public void OnGet(string lang)
        {
            lang = "RU";
            Decks = _deckService.GetDecks(lang);
        }
    }
}
