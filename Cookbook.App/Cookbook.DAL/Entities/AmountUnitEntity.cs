using Cookbook.DAL.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.DAL.Entities
{
    public class AmountUnitEntity : EntityBase
    {
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}
