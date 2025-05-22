using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public string logo { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
