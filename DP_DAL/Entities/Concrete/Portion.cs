using DP_DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_DAL.Entities.Concrete
{
    public class Portion : BaseEntity
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public virtual ICollection<Food> Foods { get; set; } = new List<Food>();

        public virtual ICollection<Beverages> Beverages { get; set; } = new List<Beverages>();

        public override string ToString()
        {
            return Name;
        }
    }

}
