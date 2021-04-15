using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RecipesForYou.Models.Ingredients;

namespace RecipesForYou.Models
{
    
    public class Recipe
    {
        public Recipe()
        {
            _Ingredients = new List<Ingredient>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(120,MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(120,MinimumLength = 5)]
        public string Summary { get; set; }
        [Required]
        public Yield.Yield _Yield { get; set; }
        [Required]
        public List<Ingredient> _Ingredients { get; set; }
        [Required]
        public Chief _Chief { get; set; }
        [Required] public int ApproximateCoast { get; set; }
    }
}