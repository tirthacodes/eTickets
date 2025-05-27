using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Profile Picture")]

        [Required(ErrorMessage = "Profile picture is required")]
        public string profilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string fullName { get; set; }


        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string bio { get; set; }


        //relationships
        public List<Actor_Movie> Actors_Movies { get;  set; } = new List<Actor_Movie>();


    }
}
