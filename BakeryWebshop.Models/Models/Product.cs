using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryWebshop.Models.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [DisplayName("Mass (g)")]
        [Required]
        public int Mass { get; set; }
        [DisplayName("Calories (kcal)")]
        [Required]
        public int Calories { get; set; }
        [DisplayName("Carbs (g)")]
        [Required]
        public int Carbs { get; set; }
        [DisplayName("Protein (g)")]
        [Required]
        public int Protein { get; set; }
        [DisplayName("Fats (g)")]
        [Required]
        public int Fats { get; set; }
        [DisplayName("Price €")]
        [Range(1D, 1000D)]
        public double Price { get; set; }
    }
}
