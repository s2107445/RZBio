using System.ComponentModel.DataAnnotations;

namespace RZBio1._1.Models
{
    public class Booking
    {
        [Key]
        public required int BookingID { get; set; }
        public required Show ShowID { get; set; }

        public required List<Lounge> ChairID { get; set; }

        public required string CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
    }
}
