using Bookingsystem.Mockdata;
using Bookingsystem.Oversigt;

namespace Bookingsystem.Service
{
    public class LokaleServiceKlasse : LokaleService
    {
        private List<Lokale> lokaler;

        public LokaleServiceKlasse()
        {
            lokaler = MockItems.GetMockItems();
        }

        public List<Lokale> GetAllLMockItems()
        {
            return lokaler;
        }
        public void AddLokale(Lokale Lokale)
        {
            lokaler.Add(Lokale);
        }

    }
}


   
