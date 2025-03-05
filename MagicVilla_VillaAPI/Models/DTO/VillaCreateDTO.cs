﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaCreateDTO
    {

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int Occupancy { get; set; }

        public int sqft { get; set; }

        public string ImageUrl { get; set; }

        public string Amenity { get; set; }

        public string Details { get; set; }

        [Required]
        public double Rate { get; set; }


    }
}
