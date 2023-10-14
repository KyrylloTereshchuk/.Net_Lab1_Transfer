using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class IEqualityComparer : IEqualityComparer<Employees>
    {

        public bool Equals(Employees x, Employees y)
        {

            bool Result = false;
            if (x.LastName == y.LastName &&
                x.FirstName == y.FirstName &&
                x.MiddleName == y.MiddleName &&
                (x.DateOfBirth == y.DateOfBirth || (x.DateOfBirth is null || y.DateOfBirth is null)) &&
                x.EmployeeId == y.EmployeeId &&
                x.RollNumber == y.RollNumber &&
                x.Education == y.Education &&
                x.Specialty == y.Specialty &&
                (x.HireDate == y.HireDate || (x.HireDate is null || y.HireDate is null)))
                Result = true;
            return Result;
        }

        public int GetHashCode(Employees obj)
        {
            return obj.EmployeeId;
        }
    }

}
