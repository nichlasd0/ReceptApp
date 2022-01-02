using System.ComponentModel.DataAnnotations;

namespace ReceptApp.Models
{
    public class RecipeDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
