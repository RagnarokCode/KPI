using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.EntityFramework
{
    public class Projects
    {
        //Scalar properties
        public int ProjectsId { get; set; }
        public int ProjectsTeamId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectStatus { get; set; }
        public int CompanyId { get; set; }

        //Navigation properties
        public TimeTotal TimeTotal { get; set; }
        public virtual ICollection<ProjectTaskList> ProjectTaskList { get; set; }
        public virtual Company Company { get; set; }
    }
}
