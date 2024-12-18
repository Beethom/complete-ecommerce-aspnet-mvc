﻿using eTickets.Data.Base;
using eTickets.Models;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema logo")]
        [Required(ErrorMessage = "Cinema Logo is required")]

        public string Logo { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Cinema Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]


        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}

