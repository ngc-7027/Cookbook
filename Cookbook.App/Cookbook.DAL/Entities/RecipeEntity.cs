using Cookbook.Common.Enums;
using Cookbook.DAL.Entities.Base;
using System;
using System.Collections.Generic;

namespace Cookbook.DAL.Entities
{
    public class RecipeEntity : EntityBase
    {
        public string Name { get; set; }
        public string Directions { get; set; }
        public int Servings { get; set; }
        public DateTime RecipeWasAdded { get; set; }
        public TimeSpan PrepTime { get; set; }
        public TimeSpan CookTime { get; set; }
        public TimeSpan AdditionalTime { get; set; }
        public TimeSpan TotalTime
        {
            get
            {
                return PrepTime + CookTime + AdditionalTime;
            }
        }
        public FoodCategory FoodCategory { get; set; }
        public FoodSpecialDiet FoodSpecialDiet { get; set; }
        public DegreeOfDifficulty DegreeOfDifficulty { get; set; }
        public AuthorEntity Author { get; set; }
        public NutritionInfoEntity NutritionInfo { get; set; }
        public ICollection<RecipeIngredientEntity> RecipeIngredients { get; set; }
        public ICollection<ReviewEntity> Reviews { get; set; }
    }
}
