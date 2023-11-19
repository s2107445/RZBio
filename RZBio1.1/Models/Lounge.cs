using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Lounge
    {
        //Ifall vi ångrar oss sen och vill använda konstruktor för att instansiera "Lounge" så kan vi ta bort alla required och ?(Nullable ok).


        [Key]
        public required int LoungeID {  get; set; }
        public required int ChairsAmount { get; set; }

        //Se över hur vi ska göra med stolarna, Kanske behöver skapa egen klass med stolar? (Saknar Chair ID mm¨)
        //Borde dock gå att köra med en array/List och tilldela en stol ID för varje stol med en For loop eller liknande.
        public List<Lounge> AvailableChairs { get; set; }
        public List<Lounge> OccupiedChairs { get; set; }


    }
}
