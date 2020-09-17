using Cookbook.Common.Enums;
using Cookbook.DAL.Entities.Base;
using System;

namespace Cookbook.DAL.Entities
{
    public class ReviewEntity : EntityBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ReviewText { get; set; }
        public Rating Rating { get; set; }
        public Guid RecipeId { get; set; }
        public RecipeEntity Recipe { get; set; }
    }
}
