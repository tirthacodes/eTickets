using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Profile Picture")]
        public string profilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string fullName { get; set; }
        [Display(Name = "Bio")]

        public string bio { get; set; }


        //relationships
        public List<Actor_Movie> Actors_Movies { get;  set; }


    }
}
