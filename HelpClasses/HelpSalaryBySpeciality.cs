using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class HelpSalaryBySpeciality
    {
        public string Speciality { get; set; }
        public IEnumerable<Salary>? MonthlySalaries { get; set; }

        public HelpSalaryBySpeciality(string speciality, IEnumerable<Salary> monthlySalry)
        {
            Speciality = speciality;
            MonthlySalaries = monthlySalry;
        }

        public override string ToString()
        {
            string salariesString = string.Join(", ", MonthlySalaries);

            return string.Format(
                $"Speciality: {this.Speciality};" +
                $"Monthly salaries: {salariesString};\n"
            );
        }
    }
}
