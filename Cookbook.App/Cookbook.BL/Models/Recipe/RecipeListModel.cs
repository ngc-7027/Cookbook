using Cookbook.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.BL.Models.Recipe
{
    public class RecipeListModel
    {
        public string Name { get; set; }
        public TimeSpan TotalTime { get; set; }
        public FoodCategory FoodCategory { get; set; }
        public FoodSpecialDiet FoodSpecialDiet { get; set; }
        public DegreeOfDifficulty DegreeOfDifficulty { get; set; }

    }
}
