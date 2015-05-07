using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.Teamwork
{
    public class TeamTimeMapping
    {
        [DataContract(Name = "Company")]
        public class CompanyTimeMapping
        {
            [DataMember(Name = "name")]
            public string NameTimeMapping { get; set; }
            [DataMember(Name = "id")]
            public string IdTimeMapping { get; set; }
        }

        [DataContract]
        public class TimeEstimates
        {
            [DataMember(Name = "total-hours-estimated")] //datamembers is used because name of the json property has a hyphen [jsonproperty("total-hours-estimated")] will work to
            public string TotalHoursEstimated { get; set; }
            [DataMember(Name = "active-mins-estimated")]
            public string ActiveMinsEstimated { get; set; }
            [DataMember(Name = "total-mins-estimated")]
            public string TotalMinsEstimated { get; set; }
            [DataMember(Name = "active-hours-estimated")]
            public string ActiveHoursEstimated { get; set; }
            [DataMember(Name = "completed-hours-estimated")]
            public string CompletedHoursEstimated { get; set; }
            [DataMember(Name = "completed-mins-estimated")]
            public string CompletedMinsEstimated { get; set; }
        }

        [DataContract]
        public class TimeTotals
        {
            [DataMember(Name = "total-mins-sum")]
            public string TotalMinsSum { get; set; }
            [DataMember(Name = "non-billed-mins-sum")]
            public string NonBilledMinsSum { get; set; }
            [DataMember(Name = "non-billable-hours-sum")]
            public string NonBillableHoursSum { get; set; }
            [DataMember(Name = "total-hours-sum")]
            public double TotalHoursSum { get; set; }
            [DataMember(Name = "billed-mins-sum")]
            public string BilledMinsSum { get; set; }
            [DataMember(Name = "billed-hours-sum")]
            public string BilledHoursSum { get; set; }
            [DataMember(Name = "billable-bours-sum")]
            public string BillableBoursSum { get; set; }
            [DataMember(Name = "non-billable-mins-sum")]
            public string NonBillableMinsSum { get; set; }
            [DataMember(Name = "non-billed-hours-sum")]
            public string NonBilledHoursSum { get; set; }
            [DataMember(Name = "billable-mins-sum")]
            public string BillableMinsSum { get; set; }
        }

        [DataContract]
        public class Project
        {
            [DataMember(Name = "company")]
            public CompanyTimeMapping CompanyTimeMapping { get; set; }
            [DataMember(Name = "time-estimates")]
            public TimeEstimates TimeEstimates { get; set; }
            [DataMember]
            public string name { get; set; }
            [DataMember]
            public string id { get; set; }
            [DataMember(Name = "time-totals")]
            public TimeTotals Timetotals { get; set; }
        }



        public class MyTime
        {
            public string STATUS { get; set; }
            public Project[] projects { get; set; }
        }
    }
}
