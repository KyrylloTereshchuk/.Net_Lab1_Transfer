using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class EmployeesSalaries
    {
        public int EmployeeId { get; }

        public int SalaryId { get; set; }

        public EmployeesSalaries(int employeeId, int salaryId)
        {
            this.EmployeeId = employeeId;
            this.SalaryId = salaryId;
        }

        public override string ToString()
        {
            return string.Format(
                $"Employee Id = {this.EmployeeId};" +
                $"Salary Id = {this.SalaryId}\n");
        }
    }
}
