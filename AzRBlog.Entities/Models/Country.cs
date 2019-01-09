﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AzRBlog.Entities.Models
{

    public class Country : Entity<int>
    {
        public Country()
        {
            Persons = new List<UserProfile>();
        }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Country Name")]
        [RegularExpression(@"^[a-zA-Z_][a-zA-Z0-9 \-/_']{1,100}$",
            ErrorMessage = "Only Alphanumeric & [-/_'] Special Characters Are Allowed.")]
        public string Name { get; set; }

        public List<UserProfile> Persons { get; set; }
    }
}