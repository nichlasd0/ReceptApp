using ReceptApp.Models;

namespace ReceptApp.Repository.IRepository
{
    public interface IRecipeRepository
    {
        ICollection<Recipe> GetRecipes();
        Recipe GetRecipe(int recipeId);
        bool RecipeExists(string name);
        bool RecipeExists(int id);
        bool CreateRecipe(Recipe recipe);
        bool UpdateRecipe(Recipe recipe);
        bool DeleteRecipe(Recipe recipe);
        bool Save();
    }
}
