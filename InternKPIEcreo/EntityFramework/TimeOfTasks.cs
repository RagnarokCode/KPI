using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.EntityFramework
{
    public class TimeOfTasks
    {
        //Scalar properties
        public int TimeOfTasksId { get; set; }
        public double TaskTotalHoursEst { get; set; }
        public double TaskActiveHoursEst { get; set; }
        public double TaskCompletedHoursEst { get; set; }
        public double TaskTotalHoursSum { get; set; }
        public double TaskNonBillableHoursSum { get; set; }
        public double TaskBilledHoursSum { get; set; }
        public double TaskNonBilledHoursSum { get; set; }
        public int ProjectTaskListIdTaskList { get; set; }

        //Navigation properties
        public virtual ProjectTaskList ProjectTaskList { get; set; }
    }
}
