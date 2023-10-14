using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class MenuDictionary
    {
        private readonly ICommands _Commands;
        public MenuDictionary(ICommands command)
        {
            _Commands = command;
        }


        public Dictionary<Enums.QueriesNames, Action> MenuCreate()
        {
            var menuChoices = new Dictionary<Enums.QueriesNames, Action>()
               {
                       {Enums.QueriesNames.Exit, () => _Commands.Exit()},
                       {Enums.QueriesNames.GetEmployees, () => _Commands.Command1()},
                       {Enums.QueriesNames.GetEmployeesFullName, () => _Commands.Command2()},
                       {Enums.QueriesNames.GetEmployeesWithEducation, () => _Commands.Command3()},
                       {Enums.QueriesNames.GetCompaniesStartWith, () => _Commands.Command4()},
                       {Enums.QueriesNames.GetEmployeesOlderAndWithIdLongerThan, () => _Commands.Command5()},
                       {Enums.QueriesNames.GetEmployeesSalaries, () => _Commands.Command6()},
                       {Enums.QueriesNames.GetEmployeesWhoseEducationIs, () => _Commands.Command7()},
                       {Enums.QueriesNames.GetMaxIdEmployeeWhoGotSalary, () => _Commands.Command8()},
                       {Enums.QueriesNames.GetFirstEmployeeWithEducation, () => _Commands.Command9()},
                       {Enums.QueriesNames.GetEmployeesWithUseDelegate, () => _Commands.Command10()},
                       {Enums.QueriesNames.GetSalaryBySpeciality, () => _Commands.Command11()},
                       {Enums.QueriesNames.GetEmployeesByCondition, () => _Commands.Command12()},
                       {Enums.QueriesNames.GetEmployeesFromTo, () => _Commands.Command13()},
                       {Enums.QueriesNames.GetEmployeesAndTheirSalaryId, () => _Commands.Command14()},
                       {Enums.QueriesNames.GetAllEducation, () => _Commands.Command15()},
                       {Enums.QueriesNames.GetNumberOfEmployeesWithEducation, () => _Commands.Command16()},
                       {Enums.QueriesNames.GetEmployeesSalariesArray, () => _Commands.Command17()},
                       {Enums.QueriesNames.GetLookup, () => _Commands.Command18()},
                       {Enums.QueriesNames.GetAllCardId, () => _Commands.Command19()},
                       {Enums.QueriesNames.GetEmployeesWithoutSalaries, () => _Commands.Command20()},
                       {Enums.QueriesNames.GetEmployeesBySpeciality, () => _Commands.Command21()},
               };
            return menuChoices;
        }
    }
}
