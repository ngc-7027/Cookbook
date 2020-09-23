using Cookbook.BL.Models.AmountUnit;
using Cookbook.BL.Models.Ingredient;
using System;

namespace Cookbook.BL.Models.Recipe.RecipeIngredient
{
    public class RecipeIngredientDetailModel
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public AmountUnitDetailModel AmountUnit { get; set; }
        public IngredientDetailModel Ingredient { get; set; }
    }
}
