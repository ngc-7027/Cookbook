using System;

namespace Cookbook.BL.Models.Recipe.RecipeIngredient
{
    public class RecipeIngredientListModel
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public string AmountUnitAbbreviation { get; set; }
        public string IngredientName { get; set; }
    }
}
