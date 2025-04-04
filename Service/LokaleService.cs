using Bookingsystem.Oversigt;

namespace Bookingsystem.Service
{
    public interface LokaleService
    {
        List<Lokale> GetAllLMockItems();
        public void AddLokale(Lokale lokale);
    }
}
