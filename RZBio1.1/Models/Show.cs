using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Show
    {
        //Ifall vi ångrar oss sen och vill använda konstruktor för att instansiera "Show" så kan vi ta bort alla required och ?(Nullable ok). 

        [Key]
        public required int ShowID { get; set; }
        public required Movie Movie { get; set; }
        public required Lounge LoungeID { get; set; }
        public required DateOnly Date { get; set; }
        public required TimeOnly TimeStart { get; set; }

    }
}
