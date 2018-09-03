using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONAPP
{
    public class Employee
    {
        /// <summary>
        /// created one Employee Class to get and set the JSON values
        /// </summary>
        public int EmployeeID
        {
            get;
            set;
        }
        public string EmployeeName
        {
            get;
            set;
        }
        public string DeptWorking
        {
            get;
            set;
        }
        public int Salary
        {
            get;
            set;
        }
    }
}
