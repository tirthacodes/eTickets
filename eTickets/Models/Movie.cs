using eTickets.Data.Base;
using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="Name")]
        [Required(ErrorMessage ="Name must be filled.")]
        public string name { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage ="Description must be filled.")]
        public string description { get; set; }
        [Display(Name ="Price")]
        [Required(ErrorMessage ="Price must be mentioned")]
        public double price { get; set; }
        [Display(Name = "Image URL")]
        [Required(ErrorMessage ="Please provide correct Image URL")]
        public string imageURL { get; set; }
        [Display(Name ="Start Date")]
        [Required(ErrorMessage ="Start Date must be mentioned")]
        public DateTime startDate { get; set; }
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "End Date must be mentioned")]
        public DateTime endDate { get; set; }
        [Display(Name ="Category")]
        [Required(ErrorMessage ="Category shouldn't be empty.")]
        public movieCategory movieCategory { get; set; }

        //relationships 
        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinmea
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }


        //producer
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
