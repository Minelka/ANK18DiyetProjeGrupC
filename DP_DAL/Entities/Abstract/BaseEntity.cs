using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Abstract
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } 
        public DateTime Created { get; set; } 
        public DateTime? Modified { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
