using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternKPIEcreo.EntityFramework
{
    public class TimeTotal
    {
        //Scalar properties
        public int TimeTotalId { get; set; }
        public double TotalHoursSum { get; set; }
        public double BilledHoursSum { get; set; }
        public double NonBilledHoursSum { get; set; }
        public double TotalHoursEst { get; set; }
        public double CompletedHoursEst { get; set; }
        public double ActiveHoursEst { get; set; }

        //Navigation properties
        
    }
}
