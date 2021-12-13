using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPharmacyManagement
{
    public class Account
    {
        private double balance = 500;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
