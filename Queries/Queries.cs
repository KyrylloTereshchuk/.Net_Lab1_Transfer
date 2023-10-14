using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Queries : IQueries
    {
        private readonly ICollections _collections;
        public Queries(ICollections c)
        {
            _collections = c;
        }


        public IEnumerable<Employees> GetEmployees()
        {
            return from x in _collections.Employees
                  select x;
        }

        public IEnumerable<HelpEmployeesFullName> GetEmployeesFullName()
        {
            return from x in _collections.Employees
                   select new HelpEmployeesFullName( x.LastName, x.FirstName, x.MiddleName );
        }

        public IEnumerable<Employees> GetEmployeesWithEducation( string education)
        {
            var query = from x in _collections.Employees
                     where x.Education == education
                        select x;
            return query;
        }

        // GetCompaniesStartWith using the extension method
        /* public IEnumerable<string> GetCompaniesStartWith(string BegginingOfName)
         {
             var query = from x in _collections.Companies
                         where x.Name.StartsWith(BegginingOfName)
                         select x.Name;
             return query;
         }*/
        // GetCompaniesStartWith using the own extension method
        public IEnumerable<string> GetCompaniesStartWith(string BegginingOfName)
        {
            var query = from x in _collections.Companies.CompanyStartsWith(BegginingOfName)
                        select x.Name;
            return query;
        }

        public IEnumerable<Employees> GetEmployeesYoungerAndWithIdLongerThan( int MinId, DateOnly MaxDate)
        {
            var query = from x in _collections.Employees
                        where 
                        (x.EmployeeId > MinId) &&
                        (x.DateOfBirth < MaxDate)
                        select x;
            return query;
        }

        public IEnumerable<HelpEmployeesSalaries> GetEmployeesSalaries()
        {
            var query = from x in _collections.Employees
                     from y in _collections.Salary
                     from z in _collections.EmployeesSalaries
                     where (z.SalaryId == y.EmployeeId) &&
                     (z.EmployeeId == x.EmployeeId)
                     orderby x.LastName
                     select new HelpEmployeesSalaries ( x.LastName, x.FirstName, x.MiddleName, y.MonthlySalaries );
            return query;
        }

        public IEnumerable<Employees> GetEmployeesWhoseEducationIs(string education)
        {
            var query = from x in _collections.Employees.WhoseEducationIs(education)
                        select x;
            return query;
        }

        public int GetMaxIdEmployeeWhoGotSalary()
        {
            return _collections.Salary.Where(a => a.MonthlySalaries != null).Max(b => b.EmployeeId);
        }

        public Employees GetFirstEmployeeWithEducation(string education)
        {
            var query = (from x in _collections.Employees select x).First(x => x.Education == education);
            return query;
        }

        public IEnumerable<Employees> GetEmployeesWithUseDelegate(Func<string, bool> startOrEnd)
        {
            var query = from x in _collections.Employees.EmployeesNameStartsOrEndsWith(startOrEnd)
                        select x;
            return query;
        }

        public IEnumerable<HelpSalaryBySpeciality> GetSalaryBySpeciality()
        {
            var query =  _collections.Employees.GroupJoin(_collections.Salary, a => a.EmployeeId, b => b.EmployeeId, (a, b) =>
              new HelpSalaryBySpeciality (  a.Specialty,  b ) );
            return query;
        }

        public IEnumerable<Employees> GetEmployeesByCondition( int employeesId, string education1, string education2)
        {
            var query = _collections.Employees.Where((x) =>
            {
                return (x.EmployeeId < employeesId) && ((x.Education == education1) ||
                    (x.Education == education2));
            }).OrderBy(x => x.Education).ThenByDescending(x => x.EmployeeId);
            return query;
        }

        public IEnumerable<Employees> GetEmployeesFromTo( DateOnly MinDate, DateOnly MaxDate)
        {
            var query = _collections.Employees.SkipWhile(employee => (employee.HireDate < MinDate))
                        .TakeWhile(employee => employee.HireDate <= MaxDate);
            return query;
        }

        public IEnumerable<HelpEmployeesAndTheirSalaryId> GetEmployeesAndTheirSalaryId()
        {
            var AllEmployees = _collections.Employees.Concat(_collections.EmployeesWithoutEmployement);

            
            var query = (from x in AllEmployees
                      join y in _collections.EmployeesSalaries
                      on x.EmployeeId equals y.EmployeeId into temp
                      from t in temp.DefaultIfEmpty()
                      select new HelpEmployeesAndTheirSalaryId (  x.LastName,  (t == null) ? 0 : t.SalaryId )).DistinctBy(e => e.LastName);
            return query;
        }

        public IEnumerable<string> GetAllEducation()
        {
            var query = (from x in _collections.Employees
                         select x.Education).Distinct();
            return query;
        }

        public int GetNumberOfEmployeesWithEducation(string education)
        {
            var query = _collections.Employees.Count(x => x.Education == education);
            return query;
        }

        public EmployeesSalaries [] GetEmployeesSalariesArray()
        {
            var query = (from x in _collections.EmployeesSalaries select x).ToArray();
            return query;
        }

        public ILookup<DateOnly?, string> GetLookup()
        {
            var query = (from x in _collections.Employees
                                select x).ToLookup(x => x.HireDate, x => x.LastName);
            return (ILookup<DateOnly?, string>)query;
        }
        public string GetAllCardId()
        {
            var query = _collections.Employees
                        .Aggregate(new Employees(""), (total, current) =>
                        {
                            total.RollNumber += current.RollNumber + " ";
                            return total;
                        });
            return query.RollNumber;
        }

        public IEnumerable<Employees> GetEmployeesWithoutSalary()
        {
            var query = _collections.EmployeesWithoutEmployement
                .Except(_collections.Employees, new IEqualityComparer());
            return query;
        }

        public List<string> GetEmployeesBySpeciality(string speciality)
        {
            List<string> employeesName = new List<string>();

            var query = _collections.Employees.GroupBy(p => p.Specialty);
            foreach (var group in query)
            {
                if (group.Key == speciality)
                {
                    foreach (var employee in group)
                    {
                         employeesName.Add( employee.LastName);                      
                    }
                }
            }
            return employeesName;
        }

    }

}
