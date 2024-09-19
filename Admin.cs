using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasDay2
{
    public class Admin : User
    {
        public Admin(string name, string role) : base(name, role)
        {
        }

        public void TambahSaldo(Customer customer, int saldo)
        {
            customer.Emoney = saldo + customer.Emoney;
        }
    }
}
