using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public  class Salary
    {
        public int EmployeeId { get; }
        public List<decimal>? MonthlySalaries { get; set; }

        public Salary(int employeeId)
        {
            EmployeeId = employeeId;
            MonthlySalaries = new List<decimal>();
        }

        public void AddSalary(decimal salary)
        {
            MonthlySalaries.Add(salary);
        }

        public override string ToString()
        {
            string salariesString = string.Join(", ", MonthlySalaries);

            return string.Format(
                $"Employee Id: {this.EmployeeId};\n" +
                $"Monthly Salaries: {salariesString};\n"
            );
        }
    }
}
