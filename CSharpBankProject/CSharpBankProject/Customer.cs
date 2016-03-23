using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankProject
{
    public class Customer : Person
    {
        private long accountNumber;
        private double accountBalance;
        private long creditScore;
        private string accountStartDate;
        private string customer;
        private string person;
       
        
         
        
       

        public Customer()
        {
            
        }

        public Customer(long AccountNumber, double AccountBalance, long CreditScore, string AccountStartDate)

        {
           
            accountNumber = AccountNumber;
            accountBalance = AccountBalance;
            creditScore = CreditScore;
            accountStartDate = AccountStartDate;
            
        }
        public String GetCustomer()
        {
            GetPerson();
            Console.WriteLine("Enter customer's new account number: ");
            accountNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter starting deposit amount: ");
            accountBalance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Customer's starting balance is: $" + accountBalance);
            Console.WriteLine("Customer's credit score: ");
            creditScore = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Date account was opened: ");
            accountStartDate = Console.ReadLine();
            return customer;
        }

        public double GetBalance()
        {
            return accountBalance;
        }

        public double DepositTo(double Deposit)
        {
            double deposit;
            deposit = Deposit;
            accountBalance += deposit;
            return deposit;
        }

        public double ChargeFrom(double Charge)
        {
            double charge;
            charge = Charge;
            accountBalance -= charge;
            return charge;
        }

        public string ToString()
        {
            return "Customer Name: " + firstName + " " + lastName + "\n Birthdate: " + dob + "\nSocial Security #: " +
                   socSecurity
                   + "\nAccount Number: " + accountNumber + "\nCurrent Balance: $" + accountBalance +
                   "\nCustomer Credit Score: " +
                   creditScore + "\nAccount Started On: " + accountStartDate;
        }
    }
}
