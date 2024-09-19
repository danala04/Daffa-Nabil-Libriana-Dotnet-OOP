using System;

namespace TugasDay2
{
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
