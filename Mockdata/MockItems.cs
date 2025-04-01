using Bookingsystem.Oversigt;
using Bookingsystem.Pages.Lokale;

namespace Bookingsystem.Mockdata
{
    public class MockItems
    {
        private static List<Lokale> Lokaler = new List<Lokale>()
        {
            new Lokale("Lokale", 10, "tavle"),
            new Lokale("Lokale", 20, "Tavle og Højbord"),
            new Lokale("Lokale", 40, "Højbord og lille skærm")

        };

        public static List<Lokale> GetMockItems()
        {
            return Lokaler;
        }
    }
   
 }
    
