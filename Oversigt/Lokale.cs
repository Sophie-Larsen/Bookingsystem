using System.ComponentModel.DataAnnotations;

namespace Bookingsystem.Oversigt
{
    public class Lokale
    {
        [Display(Name = "Lokale")]
        [Required(ErrorMessage = "Der skal angives et navn til Lokale"), MaxLength(30)]
        public string Navn { get;  set; }

        [Display(Name = "Størrelse")]
        [Required (ErrorMessage = "Der skal angives en størrelse")]
        [Range(typeof(int), minimum: "10", maximum: "100", ErrorMessage = "Størrelse på lokalet skal være mellem {1} og {2}")]
        public int Størrelse { get;  set; }

        [Display(Name = "udstyr")]
        [Required(ErrorMessage = "Der skal tilføjes udstyr")]
        public string Udstyr { get;  set; }


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
