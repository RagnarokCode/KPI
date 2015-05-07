using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.EntityFramework
{
    public class Company
    {
        //Scalar properties
        public int CompanyId { get; set; }
        public int CompanyTeamId { get; set; }
        public string CompanyName { get; set; }

        //Navigation properties
        public virtual ICollection<Projects> ProjectsList { get; set; } //virtual makes this lazily loaded
    }
}
