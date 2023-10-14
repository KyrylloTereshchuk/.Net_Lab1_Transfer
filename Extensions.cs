using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class Extensions
    {
        public static IEnumerable<Employees> WhoseEducationIs(this IEnumerable<Employees> employees, string education)
        {
            return employees.Where(employee => employee.Education == education);
        }

        public static IEnumerable<Company> CompanyStartsWith(this IEnumerable<Company> companies, string startsWith)
        {
            return companies.Where(a => a.Name.StartsWith(startsWith));
        }

        public static IEnumerable<Employees> EmployeesNameStartsOrEndsWith(this IEnumerable<Employees> employees, Func<string, bool> startOrEnd)
        {
            return employees.Where(a => startOrEnd(a.FirstName));
        }


    }
}
