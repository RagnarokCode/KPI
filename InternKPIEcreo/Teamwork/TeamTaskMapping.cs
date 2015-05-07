using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using InternKPIEcreo.EntityFramework;

namespace InternKPIEcreo.Teamwork
{
    public class TeamTaskMapping
    {
        #region TodoItem holds attributes of json file obtained from http://ecreo.teamwork.com/projects/{id}/tasks.json

        [DataContract(Name = "Company")]
        public class CompanyTask
        {
            [DataMember(Name = "name")]
            public string NameCompanyTask { get; set; }
            [DataMember(Name = "id")]
            public string IdCompanyTask { get; set; }
        }

        [DataContract(Name = "TimeEstimates")]
        public class TimeEstimatesTask
        {
            [DataMember(Name = "total-hours-estimated")]
            public string TotalHoursEstimatedTask { get; set; }
            [DataMember(Name = "active-mins-estimated")]
            public string ActiveMinsEstimatedTask { get; set; }
            [DataMember(Name = "total-mins-estimated")]
            public string TotalMinsEstimatedTask { get; set; }
            [DataMember(Name = "active-hours-estimated")]
            public string ActiveHoursEstimatedTask { get; set; }
            [DataMember(Name = "completed-hours-estimated")]
            public string CompletedHoursEstimatedTask { get; set; }
            [DataMember(Name = "completed-mins-estimated")]
            public string CompletedMinsEstimatedTask { get; set; }
        }

        [DataContract(Name = "TimeTotals")]
        public class TimeTotalsTask
        {
            [DataMember(Name = "total-mins-sum")]
            public string TotalMinsSumTask { get; set; }
            [DataMember(Name = "non-billed-mins-sum")]
            public string NonBilledMinsSumTask { get; set; }
            [DataMember(Name = "non-billable-hours-sum")]
            public string NonBillableHoursSumTask { get; set; }
            [DataMember(Name = "total-hours-sum")]
            public string TotalHoursSumTask { get; set; }
            [DataMember(Name = "billed-mins-sum")]
            public string BilledMinsSumTask { get; set; }
            [DataMember(Name = "billed-hours-sum")]
            public string BilledHoursSumTask { get; set; }
            [DataMember(Name = "billable-bours-sum")]
            public string BillableBoursSumTask { get; set; }
            [DataMember(Name = "non-billable-mins-sum")]
            public string NonBillableMinsSumTask { get; set; }
            [DataMember(Name = "non-billed-hours-sum")]
            public string NonBilledHoursSumTask { get; set; }
            [DataMember(Name = "billable-mins-sum")]
            public string BillableMinsSumTask { get; set; }
        }

        [DataContract(Name = "Project")]
        public class ProjectTask
        {
            [DataMember(Name = "company")]
            public Company CompanyTask { get; set; }
            [DataMember(Name = "time-estimates")]
            public TimeEstimatesTask TimeEstimatesTask { get; set; }
            [DataMember(Name = "name")]
            public string NameTask { get; set; }
            [DataMember(Name = "id")]
            public string IdTask { get; set; }
            [DataMember(Name = "name__time-totals")]
            public TimeTotalsTask TimeTotalsTask { get; set; }
        }

        public class MyTask
        {
            [DataMember(Name = "STATUS")]
            public string StatusTask { get; set; }
            public List<ProjectTask> ProjectsTask { get; set; }
        }
        #endregion
    }
}
