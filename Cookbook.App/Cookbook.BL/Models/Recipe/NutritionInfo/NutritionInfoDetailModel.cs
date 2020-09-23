using System;

namespace Cookbook.BL.Models.Recipe.NutritionInfo
{
    public class NutritionInfoDetailModel
    {
        public Guid Id { get; set; }
        public double PortionSize { get; set; }
        public double Calories { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
    }
}
