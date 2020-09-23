using Cookbook.BL.Models.Author;
using Cookbook.BL.Models.Recipe.NutritionInfo;
using Cookbook.BL.Models.Recipe.RecipeIngredient;
using Cookbook.Common.Enums;
using System;
using System.Collections.Generic;

namespace Cookbook.BL.Models.Recipe
{
    public class RecipeDetailModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Directions { get; set; }
        public int Servings { get; set; }
        public DateTime RecipeWasAdded { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookTime { get; set; }
        public TimeSpan AdditionalTime { get; set; }
        public TimeSpan TotalTime { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public FoodSpecialDiet FoodSpecialDiet { get; set; }
        public DegreeOfDifficulty DegreeOfDifficulty { get; set; }
        public AuthorDetailModel Author { get; set; }
        public NutritionInfoDetailModel NutritionInfo { get; set; }
        public IList<RecipeIngredientListModel> Ingredients { get; set; }
    }
}
