using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Collections : ICollections
    {
        public Collections()
        {
            Salary = Enumerable.Range(1, 6).Select(id =>
            {
                var salary = new Salary(id);
                var random = new Random();
                for (int i = 0; i < 4; i++)
                {
                    salary.MonthlySalaries.Add(random.Next(1000, 10001));
                }
                return salary;
            }).ToList();
        }


        public IEnumerable<Employees> Employees => new List<Employees>()
        {
            new Employees("Grachov", "Artem", "Sergiyovich", 1, "EM1212", ".Net Developer", "barista") 
            {DateOfBirth = new DateOnly(2003, 3, 12), HireDate = new DateOnly(2023, 3, 21)  },

            new Employees("Tkach", "Vladislav", "Anatoliyovich", 2, "AV3256", ".Net Developer", "manager")
            {DateOfBirth = new DateOnly(2003, 12, 29), HireDate = new DateOnly(2023, 3, 20)  },

            new Employees("Hunko", "Jaroslav", "Yuriyovich", 3, "AV9275", "lawyer", "lawyer")
            {DateOfBirth = new DateOnly(2004, 1, 21), HireDate = new DateOnly(2023, 1, 12)  },

            new Employees("Petruk", "Olga", "Sergiyivna", 4, "VL3256", "JavaScript Developer", "Java Developer")
            {DateOfBirth = new DateOnly(2003, 12, 31), HireDate = new DateOnly(2023, 6, 2)  },

            new Employees("Koshilka", "Jaroslav", "Victorovich", 5, "VL9043", "Java Developer", "JavaScript Developer")
            {DateOfBirth = new DateOnly(2003, 8, 19), HireDate = new DateOnly(2022, 12, 11)  },

            new Employees("Tsvigun", "Olexandr", "Olegovich", 6, "VL2552", ".Net Developer", "HR")
            {DateOfBirth = new DateOnly(1998, 4, 30), HireDate = new DateOnly(2022, 12, 11)  }
        };


        public IEnumerable<Employees> EmployeesWithoutEmployement => new List<Employees>()
        {
            new Employees("Buk", "Anatoliy", "Ivanovich", 7, "EM1752", ".Net Developer", ".Net Developer")
            {DateOfBirth = new DateOnly(2002, 1, 27), HireDate = new DateOnly(2022, 7, 17)  },

            new Employees("Loshuk", "Irina", "Olexandrivna", 8, "AV9206", ".Net Developer", ".Net Developer")
            {DateOfBirth = new DateOnly(2004, 10, 1), HireDate = new DateOnly(2023, 2, 23)  },

             new Employees("Tsvigun", "Olexandr", "Olegovich", 6, "VL2552", ".Net Developer", "HR")
            {DateOfBirth = new DateOnly(1998, 4, 30), HireDate = new DateOnly(2022, 12, 11)  }
        };

        
        public IEnumerable<Salary> Salary { get; private set; }

        public IEnumerable<EmployeesSalaries> EmployeesSalaries
        {
            get
            {
                Dictionary<int, EmployeesSalaries> employeesSalariesDictionary = new Dictionary<int, EmployeesSalaries>();

                foreach (var employee in Employees)
                {
                    var salaryId = Salary.FirstOrDefault(s => s.EmployeeId == employee.EmployeeId)?.EmployeeId ?? 0;

                    var employeesSalaries = new EmployeesSalaries(employee.EmployeeId, salaryId);

                    if (!employeesSalariesDictionary.ContainsKey(employeesSalaries.SalaryId))
                    {
                        employeesSalariesDictionary.Add(employeesSalaries.SalaryId, employeesSalaries);
                    }
                    else
                    {
                         Console.WriteLine($"This SalaryId already exist: {employeesSalaries.SalaryId}");
                    }
                }

                return employeesSalariesDictionary.Values;
            }
        }

        public IEnumerable<Company> Companies => new List<Company>()
        {
            new Company("Monobank"),
            new Company("Squad"),
            new Company("Grib"),
        };

        private void GetSalary(IEnumerable<Salary> salary)
        {
            Random random = new Random();

            foreach (var s in salary)
            {
                for (int i = 0; i < 4; i++)
                {
                    s.MonthlySalaries.Add(random.Next(1000, 10001));
                }
            }
        }
    }

}
