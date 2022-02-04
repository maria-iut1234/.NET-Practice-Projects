using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08_EmployeeManagementSystem
{
    internal class EmployeeIDNotFoundException:ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Employee ID does not exist!\n Please input correct ID";
            }
        }

    }
}
