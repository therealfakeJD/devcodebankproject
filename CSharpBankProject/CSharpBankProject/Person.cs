using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankProject
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected string dob;
        protected long socSecurity;
        private string person;


        public Person()
        {

        }

        public Person(string FirstName, string LastName, string Dob, long SocSecurity)
        {
            firstName = FirstName;
            lastName = LastName;
            dob = Dob;
            socSecurity = SocSecurity;

        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public String GetPerson()
        {
            Console.WriteLine("Please Enter first name of new customer: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Please Enter last name of new customer: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Please enter new customer birth date: ");
            dob = Console.ReadLine();
            Console.WriteLine("Please enter new customer social security number: ");
            socSecurity = Convert.ToInt64(Console.ReadLine());
            return person;
        }
     }
}

