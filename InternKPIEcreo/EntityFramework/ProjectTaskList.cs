using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.EntityFramework
{
    public class ProjectTaskList
    {
        //Scalar properties
        public int ProjectTaskListId { get; set; }
        public string TaskDescription { get; set; }
        public int TaskToDoListFd { get; set; }
        public string TaskToDoListName { get; set; }
        public long TaskEstimatedeTime { get; set; }
        public int ProjectsTeamId { get; set; }
        public int ProjectsId { get; set; }

        //Navigation properties
        public virtual Projects Projects { get; set; }
        public virtual ICollection<TimeOfTasks> TimeOfTasks { get; set; }
    }
}
