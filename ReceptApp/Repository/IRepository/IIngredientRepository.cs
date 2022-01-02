using ReceptApp.Models;

namespace ReceptApp.Repository.IRepository
{
    public interface IIngredientRepository
    {
        ICollection<Ingredient> GetIngredients();
        Ingredient GetIngredient(int ingredientId);
        bool IngredientExists(string name);
        bool IngredientExists(int id);
        bool CreateIngredient(Ingredient ingredient);
        bool UpdateIngredient(Ingredient ingredient);
        bool DeleteIngredient(Ingredient ingredient);
        bool Save();
    }
}
