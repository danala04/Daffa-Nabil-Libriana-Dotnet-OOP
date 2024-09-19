using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasDay2
{
    public class User
    {
        private string name;
        private string role;
        protected int eMoney = 1000;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public User(string name, string role)
        {
            this.name = name;
            this.role = role;
        }
    }
}
