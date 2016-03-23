using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankProject
{
    class BankFunctions: Person
    {

        public void AddCustomers()
        {
            List<Customer> customers = new List<Customer>();
            Customer justin = new Customer();
            customers.Add(justin);
            justin.GetCustomer();
            Console.ReadLine();
            foreach (Customer customer in customers)
            {
                Console.WriteLine("FirstName: " + justin.GetFirstName() + "\nLastName: " + justin.GetLastName());
                Console.WriteLine("Customer Info: " + "\n" + customer.ToString());
                Console.WriteLine("Current Balance $" + justin.GetBalance() + "\nDeposit of: $" +
                                  justin.DepositTo(500.00) + " New Current Balance: $" + justin.GetBalance() +
                                  "\nWithdrawal of: $" + justin.ChargeFrom(269.00) + " New Current Balance: $" +
                                  justin.GetBalance());
            }
            Console.ReadLine();
        }

        public void AddBankers()
        {
            List<EmployeeBanker> bankers = new List<EmployeeBanker>();
            EmployeeBanker banker = new EmployeeBanker();
            bankers.Add(banker);
            banker.GetBanker();
            foreach (EmployeeBanker temp in bankers)
            {
                Console.WriteLine("FirstName: " + banker.GetFirstName() + "LastName: " + banker.GetLastName() + "\n" + "\n");
                Console.WriteLine("Employee Info: " + "\n" + banker.ToString() + "\n" + "\n");
            }
            Console.ReadLine();
        }

        public void AddTellers()
        {
            List<EmployeeTeller> tellers = new List<EmployeeTeller>();
            EmployeeTeller teller1 = new EmployeeTeller();
            tellers.Add(teller1);
            teller1.GetTeller();
            Console.WriteLine("*********************************");
            EmployeeTeller teller2 = new EmployeeTeller();
            tellers.Add(teller2);
            teller2.GetTeller();
            Console.WriteLine("*********************************");
            foreach (EmployeeTeller temp in tellers)
            {
                Console.WriteLine("\nTeller Info :" + "\n" + teller1.ToString() + "\n******************************" + "\n" + teller2.ToString() + "\n");
            }
            Console.ReadLine();
            if (teller1.hourlyPay < 10.00 && teller2.hourlyPay < 10.00)
            {
                Console.WriteLine(teller1.GetFirstName() + " hourly pay: $" + teller1.hourlyPay + "\n" + "\n");
                teller1.GiveRaise();
                Console.WriteLine("Teller: " + teller1.GetFirstName() + " " + teller1.GetLastName() + " Will now make: $" +
                                  teller1.hourlyPay + " per hour!" + "\n" + "\n");
                Console.WriteLine(teller2.GetFirstName() + " hourly pay: $" + teller2.hourlyPay + "\n" + "\n");
                teller2.GiveRaise();
                Console.WriteLine("Teller: " + teller2.GetFirstName() + " " + teller2.GetLastName() + " Will now make: $" +
                                  teller2.hourlyPay + " per hour!" + "\n" + "\n");
            }
            else if (teller1.hourlyPay > 10.00 && teller2.hourlyPay > 10.00)
            {
                Console.WriteLine("Tellers: " + "\n" + teller1.GetFirstName() + " and " + teller2.GetFirstName() + " will not receive a raise at this time");
            }
            Console.ReadLine();
            foreach (EmployeeTeller temp in tellers)
            {
                Console.WriteLine("Teller Info :" + "\n" + teller1.ToString() + "\n**************" + "\n" + teller2.ToString() + "\n*****************" + "\n");
            }
            Console.ReadLine();
        }


    }
}
