﻿using System.ComponentModel.DataAnnotations;

namespace BeautyNails.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        public Uri ImageUrl { get; set; }

        [Required]
        public double Price { get; set; }
    }
}