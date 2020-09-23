using Cookbook.Common.Enums;
using Cookbook.DAL.Entities.Base;
using System;

namespace Cookbook.DAL.Entities
{
    public class RecipeIngredientEntity : EntityBase
    {
        public double Amount { get; set; }
        public Guid AmountUnitId { get; set; }
        public AmountUnitEntity AmountUnit { get; set; }
        public Guid IngredientId { get; set; }
        public IngredientEntity Ingredient { get; set; }
    }
}
