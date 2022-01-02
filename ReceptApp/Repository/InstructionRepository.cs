using ReceptApp.Data;
using ReceptApp.Models;
using ReceptApp.Repository.IRepository;

namespace ReceptApp.Repository
{
    public class InstructionRepository : IInstructionRepository
    {
        private readonly ApplicationDbContext _db;
        
        public InstructionRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateInstruction(Instruction instruction)
        {
            _db.Instructions.Add(instruction);
            return Save();
        }

        public bool DeleteInstruction(Instruction instruction)
        {
            _db.Instructions.Remove(instruction);
            return Save();
        }

        public Instruction GetInstruction(int instructionId)
        {
            return _db.Instructions.FirstOrDefault(x => x.Id == instructionId);
        }

        public ICollection<Instruction> GetInstructions()
        {
            return _db.Instructions.OrderBy(x => x.InstructionStep).ToList();
        }

        public bool InstructionExists(string name)
        {
            bool value = _db.Instructions.Any(x => x.InstructionStep.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool InstructionExists(int id)
        {
            return _db.Instructions.Any(i => i.Id == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateInstruction(Instruction Instruction)
        {
            _db.Instructions.Update(Instruction);
            return Save();
        }
    }
}
