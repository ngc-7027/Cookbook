using Cookbook.Common.Enums;
using Cookbook.DAL.Entities.Base;
using System;

namespace Cookbook.DAL.Entities
{
    public class IngredientAmountEntity : EntityBase
    {
        public double Amount { get; set; }
        public Unit Unit { get; set; }
        public Guid RecipeId { get; set; }
        public RecipeEntity Recipe { get; set; }
        public Guid IngredientId { get; set; }
        public IngredientEntity Ingredient { get; set; }
    }
}
