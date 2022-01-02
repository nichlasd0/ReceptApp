using System.ComponentModel.DataAnnotations;

namespace ReceptApp.Models
{
    public class IngredientDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Amount { get; set; }
        [Required]
        public string Unit { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
