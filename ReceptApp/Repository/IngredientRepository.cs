using ReceptApp.Data;
using ReceptApp.Models;
using ReceptApp.Repository.IRepository;

namespace ReceptApp.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _db;

        public IngredientRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Add(ingredient);
            return Save();
        }

        public bool DeleteIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Remove(ingredient);
            return Save();
        }

        public Ingredient GetIngredient(int ingredientId)
        {
            return _db.Ingredients.FirstOrDefault(x => x.Id == ingredientId);
        }

        public ICollection<Ingredient> GetIngredients()
        {
            return _db.Ingredients.OrderBy(x => x.Name).ToList();
        }

        public bool IngredientExists(string name)
        {
            bool value = _db.Ingredients.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool IngredientExists(int id)
        {
            return _db.Ingredients.Any(i => i.Id == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateIngredient(Ingredient ingredient)
        {
            _db.Ingredients.Update(ingredient);
            return Save();
        }
    }
}
