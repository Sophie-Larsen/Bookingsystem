using Bookingsystem.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookingsystem.Pages.Lokale
{
    public class GetAlllokalerModel : PageModel
    {
        private LokaleServiceKlasse _lokaleService;

        public GetAlllokalerModel(LokaleServiceKlasse lokaleServiceKlasse)
        {
            this._lokaleService = lokaleServiceKlasse;
        }

        public List<Oversigt.Lokale> Lokaler { get; private set; } = new List<Oversigt.Lokale>();

        public void OnGet()
        {
            Lokaler = _lokaleService.GetAllLMockItems();
        }
    }

}