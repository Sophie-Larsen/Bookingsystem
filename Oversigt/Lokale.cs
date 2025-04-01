namespace Bookingsystem.Oversigt
{
    public class Lokale
    {
        public string Navn { get; private set; }
        public int Størrelse { get; private set; }
        public string Udstyr { get; private set; }


        public Lokale()
        {

        }

        public Lokale(string Navn, int Størrelse, string Udstyr)
        {
            {
                this.Navn = Navn;
                this.Størrelse = Størrelse;
                this.Udstyr = Udstyr;

            }

        }
    }

}
