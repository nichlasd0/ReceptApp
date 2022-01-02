using ReceptApp.Models;

namespace ReceptApp.Repository.IRepository
{
    public interface IInstructionRepository
    {
        ICollection<Instruction> GetInstructions();
        Instruction GetInstruction(int instructionId);
        bool InstructionExists(string name);
        bool InstructionExists(int id);
        bool CreateInstruction(Instruction instruction);
        bool UpdateInstruction(Instruction instruction);
        bool DeleteInstruction(Instruction instruction);
        bool Save();
    }
}
