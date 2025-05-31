using eTickets.Data.Enums;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace eTickets.ViewModels
{
    public class NewMovieVM
    {

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required")]
        public string description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Image URL is required")]
        public string imageURL { get; set; }

        [Display(Name = "Start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime startDate { get; set; }

        [Display(Name = "End date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime endDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public movieCategory movieCategory { get; set; }

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "At least one actor must be selected")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Select a cinema")]
        [Required(ErrorMessage = "Cinema is required")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer")]
        [Required(ErrorMessage = "Producer is required")]
        public int ProducerId { get; set; }

        // Dropdown data
        [BindNever]
        [ValidateNever]
        public IEnumerable<Actor> Actors { get; set; }

        [BindNever]
        [ValidateNever]
        public IEnumerable<Cinema> Cinemas { get; set; }

        [BindNever]
        [ValidateNever]
        public IEnumerable<Producer> Producers { get; set; }

    }
}
