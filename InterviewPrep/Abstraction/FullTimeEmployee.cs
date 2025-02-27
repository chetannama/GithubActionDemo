using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Abstraction
{
    public class FullTimeEmployee : BaseEmployee
    {
        public FullTimeEmployee() 
        { 
           Console.WriteLine(nameof(FullTimeEmployee));
        }

        ~FullTimeEmployee()
        {
            Console.WriteLine($"Destructor of {nameof(FullTimeEmployee)}");
        }

        public double AnnualSalary { get; set; }

        public override double MonthlySalary()
        {
            FullTimeEmployee ff = new FullTimeEmployee();
            ff.AnnualSalary = 100000;

            return ff.AnnualSalary/12;
        }
    }
}
