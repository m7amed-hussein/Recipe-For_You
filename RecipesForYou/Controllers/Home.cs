using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RecipesForYou.Models.Repositories;

namespace RecipesForYou.Controller
{
    public class Home : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IRecipeRepository _recipeRepository;

        public Home(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        // GET
        [HttpGet]
        public IActionResult Index()
        {
            var model = _recipeRepository.GetAllRecipes();
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Details(int Id)
        {
            var model = _recipeRepository.GetAllRecipes().FirstOrDefault(c => c.Id == Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(int? Id)
        {
            var recipe = _recipeRepository.GetAllRecipes().Where(r => r.Id == Id);
            if (recipe == null)
            {
                ViewBag.ErrorMessage = $"Recipe with id ={Id} is NOT FOUND";
                return View("notfound");
            }

            _recipeRepository.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}