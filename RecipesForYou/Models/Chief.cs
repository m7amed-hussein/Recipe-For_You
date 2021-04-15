using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RecipesForYou.Models
{
    public class Chief
    {
        public Chief()
        {
            Recipes = new List<Recipe>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(120,MinimumLength = 5)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        
        public string About { get; set; }
        public List<Recipe> Recipes { get; set; }
    }
}