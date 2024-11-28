﻿using System;

namespace LeadTrack.Domain.models
{
    public class Lead
    {
        public int? Id { get; set; }
        public string ContactFirstName { get; set; }
        public string? ContactFullName { get; set; }
        public string? ContactPhoneNumber { get; set; }
        public string? ContactEmail { get; set; }
        public DateTime DateCreated { get; set; }
        public string Suburb { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public StatusEnum? Status { get; set; }
    }
}