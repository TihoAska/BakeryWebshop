﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BakeryWebshop.Models.Models;

public class Category
{
    [Key]
    public int Id { get; set; } // Primary key
    [Required]
    [MaxLength(30)]
    [DisplayName("Category Name")]
    public string Name { get; set; } = string.Empty;
    [Required]
    [DisplayName("Display Order")]
    [Range(1, 100)]
    public int DisplayOrder { get; set; }
}
