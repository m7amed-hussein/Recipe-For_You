using System;
using System.ComponentModel.DataAnnotations;

namespace RecipesForYou.Models.Ingredients
{
    public class Ingredient
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public MeasuringUnit Measuring { get; set; }
        public enum MeasuringUnit
        {
            Kilogram ,gram,Liter,MLiter,SSpoon,LSpoon,Cup,ASUW
            
        }
        //ASUW stands for as you want 
        public bool Optional { get; set; }

    }
}