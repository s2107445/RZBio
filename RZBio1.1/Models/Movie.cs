using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Movie
    {
        //Ifall vi ångrar oss sen och vill använda konstruktor för att instansiera "Movie" så kan vi ta bort alla required och ?(Nullable ok). 


        [Key]
        public required int MovieID { get; set; }
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public string? Description { get; set; }
        public required float Length { get; set; }
        public required decimal Price { get; set; }
    }
}
