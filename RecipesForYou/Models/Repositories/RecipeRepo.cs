using System.Collections.Generic;
using System.Linq;

namespace RecipesForYou.Models.Repositories
{
    public class RecipeRepo:IRecipeRepository
    {
        private List<Recipe> Recipes = new List<Recipe>
        {
            new Recipe() {Id = 1, Name = "Kabsa", Summary = "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best", 
                _Chief = new Chief(){Name = "Mohamed",Email = "mohamed@gmail.com"} 
                , _Yield = new Yield.Yield(){ NumberOfServings = 5 , Measuring = Yield.Yield.MeasuringUnit.Cup}
                ,Description = "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions" +
                               "Some descritions Some descritions Some descritions Some descritions"
                
            },
            new Recipe() {Id = 2, Name = "Spageddi", Summary = "Mohamed's Spageddi is the best", 
                _Chief = new Chief(){Name = "Mohamed",Email = "mohamed@gmail.com" }
                , _Yield = new Yield.Yield(){ NumberOfServings = 5 , Measuring = Yield.Yield.MeasuringUnit.Cup}
            },
            new Recipe() {Id = 3, Name = "Indomie", Summary = "Mohamed's Indomie is the best",
                _Chief = new Chief(){Name = "Nour" ,Email = "nour@gmail.com"}
                , _Yield = new Yield.Yield(){ NumberOfServings = 5 , Measuring = Yield.Yield.MeasuringUnit.Plate}
            },
            new Recipe() {Id = 4, Name = "Kabsa", Summary = "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best" +
                                                                "Saudi's Kabsa is the best", 
                _Chief = new Chief(){Name = "Nour" ,Email = "nour@gmail.com"},
                 _Yield = new Yield.Yield(){ NumberOfServings = 5 , Measuring = Yield.Yield.MeasuringUnit.Plate}
            }
        };
        public Recipe Add(Recipe recipe)
        {
            Recipes.Add(recipe);
            return recipe;
        }

        public List<Recipe> GetAllRecipes()
        {
            return Recipes;
        }

        public Recipe Update(Recipe recipe)
        {
            var OldRecipe = Recipes.FirstOrDefault(r => r.Id == recipe.Id);
            if (OldRecipe != null)
            {
                Recipes.Remove(OldRecipe);
                Recipes.Add(recipe);
            }

            return recipe;
        }

        public Recipe Delete(int? Id)
        {
            var recipe = Recipes.FirstOrDefault(r => r.Id == Id);
            if (recipe != null)
            {
                Recipes.Remove(recipe);
            }

            return recipe;
        }
    }
}