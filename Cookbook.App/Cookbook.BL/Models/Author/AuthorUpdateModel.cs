using System;

namespace Cookbook.BL.Models.Author
{
    public class AuthorUpdateModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutAuthor { get; set; }
    }
}
