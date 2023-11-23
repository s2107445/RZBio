using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Show
    {
        [Key]
        public required int ShowID { get; set; }
        public required Movie MovieToShow { get; set; }
        public required Lounge LoungeID { get; set; }
        public required DateOnly Date { get; set; }
        public required TimeOnly TimeStart { get; set; }

    }
}
