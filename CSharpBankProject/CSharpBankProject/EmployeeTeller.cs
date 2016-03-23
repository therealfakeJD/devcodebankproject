using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankProject
{
    class EmployeeTeller: Person
    {
        private int empId;
        private string dateOfHire;
        private int securityLevel;
        public double hourlyPay;
        private string raise;
        


        public EmployeeTeller()
        {

        }

        public EmployeeTeller(int EmpId, string DateOfHire, int SecurityLevel, double HourlyPay)
        {
            GetTeller();
           
        }

        public void GetTeller()
        {
            Console.WriteLine("Front Facing Teller First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Date Of Birth: ");
            dob = Console.ReadLine();
            Console.WriteLine("Social Security Number: ");
            socSecurity = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Employee ID: ");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Date Of Hire: ");
            dateOfHire = Console.ReadLine();
            Console.WriteLine("Employee Security Level: ");
            securityLevel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Starting Pay Per Hour: $");
            hourlyPay = Convert.ToDouble(Console.ReadLine());

        }



        public double GiveRaise()
        {
            Console.WriteLine("Decide if Employee Deserves a raise... Y or N");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.WriteLine("Increase hourly pay by: $");
                var raise = Convert.ToDouble(Console.ReadLine());
                hourlyPay = raise + hourlyPay;
            }
            else if(input == "n")
            {
                Console.WriteLine("Employee will not receive a raise at this time");
            }
            return hourlyPay;
        }

        


        
        public string ToString()
        {
            return "Teller Name: " + firstName + " " + lastName + "\nDate Of Birth: " + dob +
                   "\nSocial Security Number: " +
                   socSecurity + "\nEmployee ID #: " + empId + "\nHired On: " + dateOfHire + "\nSalary: $" + hourlyPay +
                   " per hour." + "\nSecurity Level: " + securityLevel;
        }
        
    }
}
