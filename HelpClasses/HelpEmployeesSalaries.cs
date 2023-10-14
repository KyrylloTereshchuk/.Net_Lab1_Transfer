using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpEmployeesSalaries
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public List<decimal>? MonthlySalaries { get; }

        public HelpEmployeesSalaries(string lastName, string firstName, string middleName, List<decimal> monthlySalry)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            MonthlySalaries = monthlySalry;
        }

        public override string ToString()
        {
            string salariesString = string.Join(", ", MonthlySalaries);

            return string.Format(
                $"Employee: {this.LastName} " +
                $"{this.FirstName} " +
                $"{this.MiddleName}, \n" +
                $"Monthly salaries: {salariesString};\n"
            );
        }
    }
}
