using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Movie
    {
       
        [Key]
        public required int MovieID { get; set; }
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public string? Description { get; set; }
        public required int LengthInMinutes { get; set; }
        public required decimal Price { get; set; }
    }
}
