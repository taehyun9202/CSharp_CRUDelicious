using System;
using System.ComponentModel.DataAnnotations;
namespace CRUD.Models
{
    public class Menu
    {
        [Key]
        public int FoodId { get; set; }
        [Required]
        public string ChefName { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public int Calories { get; set; }
        [Required]
        public int Tastiness { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}