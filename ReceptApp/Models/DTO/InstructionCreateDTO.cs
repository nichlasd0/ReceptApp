using System.ComponentModel.DataAnnotations;

namespace ReceptApp.Models.DTO
{
    public class InstructionCreateDTO
    {
        [Required]
        public string InstructionStep { get; set; }
        [Required]
        public int RecipeId { get; set; }
    }
}
