﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string name { get; set; }
        [Display(Name = "Description")]
        public string description { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
