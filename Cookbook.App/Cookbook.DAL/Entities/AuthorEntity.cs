using Cookbook.DAL.Entities.Base;
using System.Collections.Generic;

namespace Cookbook.DAL.Entities
{
    public class AuthorEntity : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutAuthor { get; set; }
        public ICollection<RecipeEntity> Recipes { get; set; }
    }
}
