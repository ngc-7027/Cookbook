﻿using Cookbook.DAL.Entities.Base;

namespace Cookbook.DAL.Entities
{
    public class IngredientEntity : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
