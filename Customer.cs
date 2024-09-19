using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasDay2
{
    public class Customer : User
    {
        public Customer(string name, string role) : base(name, role)
        {
        }

        public int Emoney
        {
            get { return eMoney; }
            set { eMoney = value; }
        }
        public void GetSaldo()
        {
            Console.WriteLine($"Saldo EMoney: {this.eMoney}");
        }
    }
}
