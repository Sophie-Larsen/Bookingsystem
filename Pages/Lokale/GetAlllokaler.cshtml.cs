    using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Bookingsystem.Oversigt;
using System.Reflection;


namespace Bookingsystem.Pages.Lokale
{
    public class GetAlllokalerModel : PageModel
    {
        public List<Oversigt.Lokale> Lokaler { get; private set; } = new List<Oversigt.Lokale>()
            {
               new Oversigt.Lokale("LokaleA", 10, "Tavle"),
               new Oversigt.Lokale("LokaleB", 20, "Tavle og Højbord"),
               new Oversigt.Lokale("LokaleC", 40, "Højbord og lille skærm")
           };

        public void OnGet()
        {
            
           
        }
    }

}
