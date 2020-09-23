using Cookbook.BL.Models.Author;
using Cookbook.BL.Models.Recipe.NutritionInfo;
using Cookbook.BL.Models.Recipe.RecipeIngredient;
using Cookbook.Common.Enums;
using Cookbook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.BL.Models.Recipe
{
    public class RecipeUpdateModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Directions { get; set; }
        public int Servings { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookTime { get; set; }
        public TimeSpan AdditionalTime { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public FoodSpecialDiet FoodSpecialDiet { get; set; }
        public DegreeOfDifficulty DegreeOfDifficulty { get; set; }
        public AuthorDetailModel Author { get; set; }
        public NutritionInfoUpdateModel NutritionInfo { get; set; }
        public ICollection<RecipeIngredientUpdateModel> RecipeIngredients { get; set; }
    }
}
