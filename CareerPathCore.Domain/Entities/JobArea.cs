﻿using System.ComponentModel.DataAnnotations;

namespace CareerPathCore.Domain.Entities
{
    public class JobArea
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
