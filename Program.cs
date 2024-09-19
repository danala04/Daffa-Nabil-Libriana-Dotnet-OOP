using System;

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

    public class App
    {
        private static Customer[] customers = new Customer[]
        {
            new Customer("William", "Customer"),
            new Customer("Surya", "Customer"),
        };

        public static void Main(string[] args)
        {
            while (true)
            {
                string role = GetUserRole();

                if (role == "Admin")
                {
                    HandleAdminRole();
                    Console.ReadLine();
                }
                else if (role == "Customer")
                {
                    HandleCustomerRole();
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Menu tidak ditemukan!");
                    Console.ReadLine();
                }

                Console.Clear();
            }
        }

        private static string GetUserRole()
        {
            Console.Write("Masukkan Role Anda (Admin/Customer): ");
            return Console.ReadLine().Trim();
        }

        private static void HandleAdminRole()
        {
            Console.Write("[Admin] Pilih Customer (William/Surya): ");
            string customerName = Console.ReadLine().Trim();

            Customer customer = Array.Find(customers, c => c.Name.Equals(customerName));
            if (customer != null)
            {
                Console.Write("Masukkan saldo eMoney yang ingin ditambah: ");
                if (int.TryParse(Console.ReadLine(), out int saldo))
                {
                    Admin daffa = new Admin("Daffa", "Admin");

                    daffa.TambahSaldo(customer, saldo);
                    Console.WriteLine($"Saldo untuk {customer.Name} telah ditambah menjadi {customer.Emoney}.");
                }
                else
                {
                    Console.WriteLine("Input saldo tidak valid!");
                }
            }
            else
            {
                Console.WriteLine("Customer tidak ditemukan!");
            }
        }

        private static void HandleCustomerRole()
        {
            Console.Write("[Customer] Pilih Customer (William/Surya): ");
            string customerName = Console.ReadLine().Trim();
            ShowCustomerSaldo(customerName);
        }

        private static void ShowCustomerSaldo(string customerName)
        {
            Customer customer = Array.Find(customers, c => c.Name.Equals(customerName));
            if (customer != null)
            {
                customer.GetSaldo();
            }
            else
            {
                Console.WriteLine("Customer tidak ditemukan!");
            }
        }
    }
}
