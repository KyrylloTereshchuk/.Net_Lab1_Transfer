using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Commands : ICommands
    {
        private readonly IQueries _Querys;
        public Commands(IQueries query)
        {
            _Querys = query;
        }
        private void QueryOutputText(int a)
        {
            TextToConsole TextToConsole = new TextToConsole();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(TextToConsole.QueryTexts[a]);
            Console.ResetColor();
        }

        public void Exit()
        {
           QueryOutputText(0);
           Environment.Exit(0);
        }       

        public void Command1()
        {
            QueryOutputText(1);

            var allEmployees = _Querys.GetEmployees();
            foreach (var a in allEmployees)
                Console.WriteLine(a);
        }
        public void Command2()
        {
            QueryOutputText(2);

            var fullNames = _Querys.GetEmployeesFullName();
            foreach (var m in fullNames)
                Console.WriteLine(m);
        }
        public void Command3()
        {
            QueryOutputText(3);

            var withEducation = _Querys.GetEmployeesWithEducation(".Net Developer");
            foreach (var c in withEducation)
                Console.WriteLine(c);
        }
        public void Command4()
        {
            QueryOutputText(4);

            var startWith = _Querys.GetCompaniesStartWith("S");
            foreach (var a in startWith)
                Console.WriteLine(a);
        }
        public void Command5()
        {
            QueryOutputText(5);

            var olderAndLonger = _Querys.GetEmployeesYoungerAndWithIdLongerThan(0, new DateOnly(2000, 1, 1));
            foreach (var c in olderAndLonger)
                Console.WriteLine(c);
        }
        public void Command6()
        {
            QueryOutputText(6);

            var salaries = _Querys.GetEmployeesSalaries();
            foreach (var c in salaries)
                Console.WriteLine(c);
        }
     
        public void Command7()
        {
            QueryOutputText(7);

            var educationIs = _Querys.GetEmployeesWhoseEducationIs(".Net Developer");
            foreach (var a in educationIs)
                Console.WriteLine(a);
        }
        public void Command8()
        {
            QueryOutputText(8);

            Console.WriteLine(_Querys.GetMaxIdEmployeeWhoGotSalary());
        }
        public void Command9()
        {
            QueryOutputText(9);

            Console.WriteLine(_Querys.GetFirstEmployeeWithEducation(".Net Developer"));
        }
        public void Command10()
        {
            QueryOutputText(10);

            var endWith = _Querys.GetEmployeesWithUseDelegate(x => x.EndsWith("v"));
            foreach (var c in endWith)
                Console.WriteLine(c);
            var startWirh = _Querys.GetEmployeesWithUseDelegate(x => x.StartsWith("A"));
            foreach (var c in startWirh)
                Console.WriteLine(c);
        }
        public void Command11()
        {
            QueryOutputText(11);

            var salaries = _Querys.GetSalaryBySpeciality();
            foreach (var a in salaries)
            {
                Console.WriteLine($"{a.Speciality}:");
                foreach (var salary in a.MonthlySalaries)
                {
                    Console.WriteLine($"    {salary}");
                }
            }
        }
        public void Command12()
        {
            QueryOutputText(12);

            var byCondition = _Querys.GetEmployeesByCondition(999999, ".Net Developer", "Java Developer");
            foreach (var a in byCondition)
                Console.WriteLine(a);
        }
        public void Command13()
        {
            QueryOutputText(13);

            var fromTo = _Querys.GetEmployeesFromTo(new DateOnly(2021, 3, 21), new DateOnly(2023, 3, 22));
            foreach (var m in fromTo)
                Console.WriteLine(m);
        }
        public void Command14()
        {
            QueryOutputText(14);

            var EmpSalId = _Querys.GetEmployeesAndTheirSalaryId();
            foreach (var a in EmpSalId)
                Console.WriteLine(a);
        }
        public void Command15()
        {
            QueryOutputText(15);

            var allEducation = _Querys.GetAllEducation();
            foreach (var a in allEducation)
                Console.WriteLine(a);
        }
        public void Command16()
        {
            QueryOutputText(16);

            Console.WriteLine(_Querys.GetNumberOfEmployeesWithEducation(".Net Developer"));
        }
        public void Command17()
        {
            QueryOutputText(17);

            var array = _Querys.GetEmployeesSalariesArray();
            foreach (var m in array)
                Console.WriteLine(m);
        }
        public void Command18()
        {
            QueryOutputText(18);

            var lookup = _Querys.GetLookup();

            foreach (var group in lookup)
            {
                Console.WriteLine(group.Key);
                foreach (var employement in group)
                {
                    Console.WriteLine("   " + employement);
                }
            }
        }
        public void Command19()
        {
            QueryOutputText(19);

            var allCardId = _Querys.GetAllCardId();          
                Console.WriteLine(allCardId);
        }
        public void Command20()
        {
            QueryOutputText(20);

            var withoutSalary = _Querys.GetEmployeesWithoutSalary();
            foreach (var m in withoutSalary)
                Console.WriteLine(m);
        }
        public void Command21()
        {
            QueryOutputText(21);

            var bySpeciality = _Querys.GetEmployeesBySpeciality("Java Developer");
            foreach (var m in bySpeciality)
                Console.WriteLine(m);
        }
        

    }

}
