using Bookingsystem.Oversigt;
using Bookingsystem.Pages.Lokale;

namespace Bookingsystem.Mockdata
{
    public class MockItems
    {
        private static List<Lokale> Lokaler = new List<Lokale>()

        {
            new Lokale("MødelokaleA",10, "Smartboard og højbord"),
            new Lokale("MødelokaleB", 20, "Smartboard og langbord"),
            new Lokale("MødelokaleC", 40, "Projektor og langbord"),

        };
        public static List<Lokale> GetMockItems()
        {
            return Lokaler;
        }
    }
   
 }
    
