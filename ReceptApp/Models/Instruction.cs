using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReceptApp.Models
{
    public class Instruction
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string InstructionStep { get; set; }
        public int RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }
    }
}
