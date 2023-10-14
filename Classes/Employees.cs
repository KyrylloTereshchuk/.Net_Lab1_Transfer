using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Employees
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string MiddleName { get; }
        public DateOnly? DateOfBirth { get; set; }
        public int EmployeeId { get; }
        public string RollNumber { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
        public DateOnly? HireDate { get; set; }

        public Employees(string lastName, string firstName, string middleName, 
                        int employeeId, string rollNumber, string education, string specialty)
        {
            LastName = lastName;
            FirstName = firstName;
            MiddleName = middleName;
            EmployeeId = employeeId;
            RollNumber = rollNumber;
            Education = education;
            Specialty = specialty;
        }

        public Employees( string cardId)
        {
            RollNumber = cardId;
        }

        public override string ToString()
        {
            return string.Format(
                $"Last name: {this.LastName};" +
                $" First name: {this.FirstName};" +
                $" Middle name: {this.MiddleName}\n" +
                $"Date of birthday: {this.DateOfBirth};\n" +
                $" Employee Id: {this.EmployeeId};" +
                $" Card Id: {this.RollNumber};\n" +
                $" Education: {this.Education};" +
                $" Speciality: {this.Specialty};\n" +
                $" Hire date: {this.HireDate};\n"
                );
        }
    }
}
