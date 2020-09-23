using System;

namespace Cookbook.BL.Models.Recipe.RecipeIngredient
{
    public class RecipeIngredientUpdateModel
    {
        public Guid Id { get; set; }
        public double Amount { get; set; }
        public Guid AmountUnitId { get; set; }
        public Guid IngredientId { get; set; }
    }
}
