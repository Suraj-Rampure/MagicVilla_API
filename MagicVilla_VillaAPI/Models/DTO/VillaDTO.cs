﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_VillaAPI.Models.DTO
{
    public class VillaDTO
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int occupancy { get; set; }

        public int sqft { get; set; }
    }
}
