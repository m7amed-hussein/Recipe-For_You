using System.Collections.Generic;

namespace RecipesForYou.Models.Repositories
{
    public interface IRecipeRepository
    {
        public Recipe Add(Recipe recipe);
        public List<Recipe> GetAllRecipes();
        public Recipe Update(Recipe Id);
        public Recipe Delete(int? Id);
    }
}