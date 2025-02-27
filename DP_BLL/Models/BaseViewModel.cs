using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_BLL.Models
{
    public abstract class BaseViewModel
    {
        public int Id { get; set; }

        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? Deleted { get; set; }
    }
}
