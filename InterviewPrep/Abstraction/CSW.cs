using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Abstraction
{
    public class CSW : BaseEmployee
    {
        public double RatePerHour { get; set; }
        public double TotalHours { get; set; }

        public override double MonthlySalary()
        {
            return RatePerHour * TotalHours;
        }
    }
}
