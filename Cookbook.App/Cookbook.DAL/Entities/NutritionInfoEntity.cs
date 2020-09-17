using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL.Entities
{
    public class NutritionInfoEntity : EntityBase
    {
        public double PortionSize { get; set; }
        public double Calories { get; set; }
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
    }
}
