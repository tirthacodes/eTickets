using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }
        public string profilePictureURL { get; set; }
        public string fullName { get; set; }
        public string bio { get; set; }
    }
}
