using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpEmployeesAndTheirSalaryId
    {
        public string LastName { get; set; }
        public int SalaryId { get; set; }

        public HelpEmployeesAndTheirSalaryId(string lastName, int salaryId)
        {
            LastName = lastName; 
            SalaryId = salaryId; 
        }

        public override string ToString()
        {
            return string.Format(
                 $"Last name: {this.LastName}," +
                 $" salary Id: {this.SalaryId};\n"
                 );
        }
    }
}
