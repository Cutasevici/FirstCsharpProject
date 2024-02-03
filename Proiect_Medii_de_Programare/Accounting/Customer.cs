using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Medii_de_Programare.Accounting
{
    internal class Customer
    {
        private string customerId;
        private string name;

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
