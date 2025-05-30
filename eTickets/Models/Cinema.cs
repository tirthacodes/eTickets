using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage ="Logo must be provided")]
        public string logo { get; set; }
        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage ="Cinema name is empty.")]
        public string name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage ="Description should be filled.")]
        public string description { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
