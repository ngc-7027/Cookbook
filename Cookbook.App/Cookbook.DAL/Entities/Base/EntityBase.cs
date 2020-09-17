using Cookbook.DAL.Entities.Interfaces;
using System;
namespace Cookbook.DAL.Entities.Base
{
    public abstract class EntityBase : IEntity
    {
        public Guid Id { get; set; }
    }
}
