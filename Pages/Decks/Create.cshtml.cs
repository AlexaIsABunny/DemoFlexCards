using DemoAlexa.Models;
using DemoAlexa.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoAlexa.Pages.Decks
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IDeckService _deckService;

        public CreateModel(ILogger<IndexModel> logger, IDeckService deckService)
        {
            _logger = logger;
            _deckService = deckService;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(string name, string description, string language)
        {
            var deck = new Deck()
            {
                Name = name,
                Description = description,
                Language = language
            };

            _deckService.InsertDeck(deck);

            return Redirect("/Index");
        }
    }
}
