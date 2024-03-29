﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
