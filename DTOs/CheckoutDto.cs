﻿using BeautyNails.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyNails.DTOs
{
    public class CheckoutDto
    {
        public Guid? Id { get; set; }
        public int ProductId { get; set; }
        public DateTime? BookedDate { get; set; }
        public string? Address { get; set; } = string.Empty;
        public string? ZipCode { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
    }
}