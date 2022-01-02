using System.ComponentModel.DataAnnotations;

namespace ReceptApp.Models
{
    public class InstructionDTO
    {
        public int Id { get; set; }
        [Required]
        public string InstructionStep { get; set; }
        [Required]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
