using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Company
    {
        public string Name { get; }
        public List<Employees>? Employees { get; set; }

        public Company(string name)
        {
            Name = name;
            Employees = new List<Employees>();
        }

        /*public void AddEmployee(Employees employee)
        {
            Employees.Add(employee);
        }*/

        /*public override string ToString()
        {
            string employeesString;

            if (Employees != null && Employees.Count > 0)
            {
                employeesString = string.Join("\n", Employees);
            }
            else
            {
                employeesString = "Haven't any employees";
            }

            return string.Format(
                $"Company name: {this.Name};\n" +
                $"Employees:\n {employeesString}\n"
            );
        }*/
    }
}
