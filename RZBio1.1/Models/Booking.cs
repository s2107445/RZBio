using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Booking
    {
        //Ifall vi ångrar oss sen och vill använda konstruktor för att instansiera "Booking" så kan vi ta bort alla required och ?(Nullable ok). 

        [Key]
        public required int BookingID { get; set; }
        public required Show ShowID { get; set; }

        //Kan komma att ändras ifall vi vill använda en Chair class (plats som kund väljer vid boknin) som kopplas till lounge sen ist
        //Är en List istället för propperty då en "Kund" Ska kunna boka flera stolar
        public required List<Lounge> ChairID { get; set; }

        //Skapa en Customer klass?? Skapa inlogg för varje kund med? Kolla handledning
        public required string CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
    }
}
