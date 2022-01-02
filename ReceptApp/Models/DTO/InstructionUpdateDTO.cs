using System.ComponentModel.DataAnnotations;

namespace ReceptApp.Models.DTO
{
    public class InstructionUpdateDTO
    {
        public int Id { get; set; }
        [Required]
        public string InstructionStep { get; set; }
        [Required]
        public int RecipeId { get; set; }
    }
}
