using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankProject
{
    class EmployeeBanker : Person
    {
        private int empId;
        private string dateOfHire;
        private int securityLevel;
        private double salary;

        public EmployeeBanker()
        {
            
        }

        public EmployeeBanker(int EmpId, string DateOfHire, int SecurityLevel, double Salary)
        {
            GetBanker();
            empId = EmpId;
            dateOfHire = DateOfHire;
            securityLevel = SecurityLevel;
            salary = Salary;
        }

        public void GetBanker()
        {
            Console.WriteLine("New Banker First Name: ");
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
            Console.WriteLine("Starting Salary: $");
            salary = Convert.ToDouble(Console.ReadLine());
            
        }
        
        public string ToString()
        {
            return "Banker Name: " + firstName + " " + lastName + "\nDate Of Birth: " + dob +
                   "\nSocial Security Number: " +
                   socSecurity + "\nEmployee ID #: " + empId + "\nHired On: " + dateOfHire + "\nSalary: $" + salary +
                   " per year." + "\nSecurity Level: " + securityLevel;
        }
        
    }
}
