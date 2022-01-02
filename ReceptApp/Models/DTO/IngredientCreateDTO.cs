using System.ComponentModel.DataAnnotations;

namespace ReceptApp.Models.DTO
{
    public class IngredientCreateDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Amount { get; set; }
        [Required]
        public string Unit { get; set; }
        [Required]
        public int RecipeId { get; set; }
    }
}
