using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptApp.Models
{
    public class Ingredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Amount { get; set; }
        [Required]
        public string Unit { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

    }
}
