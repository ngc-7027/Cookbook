using Cookbook.BL.Models.Recipe;
using System;
using System.Collections.Generic;

namespace Cookbook.BL.Models.Author
{
    public class AuthorDetailModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutAuthor { get; set; }
        public ICollection<RecipeListModel> Recipes { get; set; }
    }
}
