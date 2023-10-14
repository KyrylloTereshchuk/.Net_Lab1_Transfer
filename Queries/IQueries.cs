using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IQueries
    {
        public IEnumerable<Employees> GetEmployees();
        public IEnumerable<HelpEmployeesFullName> GetEmployeesFullName();
        public IEnumerable<Employees> GetEmployeesWithEducation(string education);
        public IEnumerable<string> GetCompaniesStartWith(string BegginingOfName);
        public IEnumerable<Employees> GetEmployeesYoungerAndWithIdLongerThan(int MinId, DateOnly MaxDate);
        public IEnumerable<HelpEmployeesSalaries> GetEmployeesSalaries();
        public IEnumerable<Employees> GetEmployeesWhoseEducationIs(string education);
        public int GetMaxIdEmployeeWhoGotSalary();
        public Employees GetFirstEmployeeWithEducation(string education);
        public IEnumerable<Employees> GetEmployeesWithUseDelegate(Func<string, bool> predicate);
        public IEnumerable<HelpSalaryBySpeciality> GetSalaryBySpeciality();
        public IEnumerable<Employees> GetEmployeesByCondition(int employeesId, string education1, string education2);
        public IEnumerable<Employees> GetEmployeesFromTo(DateOnly MinId, DateOnly MaxId);
        public IEnumerable<HelpEmployeesAndTheirSalaryId> GetEmployeesAndTheirSalaryId();
        public IEnumerable<string> GetAllEducation();
        public int GetNumberOfEmployeesWithEducation(string education);
        public EmployeesSalaries[] GetEmployeesSalariesArray();
        public ILookup<DateOnly?, string> GetLookup();
        public string GetAllCardId();
        public IEnumerable<Employees> GetEmployeesWithoutSalary();
        public List<string> GetEmployeesBySpeciality(string speciality);
    }
}
