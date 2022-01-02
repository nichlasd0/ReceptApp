using ReceptApp.Data;
using ReceptApp.Models;
using ReceptApp.Repository.IRepository;

namespace ReceptApp.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _db;

        public RecipeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateRecipe(Recipe Recipe)
        {
            _db.Recipes.Add(Recipe);
            return Save();
        }

        public bool DeleteRecipe(Recipe Recipe)
        {
            _db.Recipes.Remove(Recipe);
            return Save();
        }

        public Recipe GetRecipe(int RecipeId)
        {
            return _db.Recipes.FirstOrDefault(x => x.Id == RecipeId);
        }

        public ICollection<Recipe> GetRecipes()
        {
            return _db.Recipes.OrderBy(x => x.Name).ToList();
        }

        public bool RecipeExists(string name)
        {
            bool value = _db.Recipes.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim());
            return value;
        }

        public bool RecipeExists(int id)
        {
            return _db.Recipes.Any(i => i.Id == id);
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateRecipe(Recipe Recipe)
        {
            _db.Recipes.Update(Recipe);
            return Save();
        }
    }
}
