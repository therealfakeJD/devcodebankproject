using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBankProject
{
    class MainBank
    {
        public static void Main(string[] args)
        {

            BankFunctions function = new BankFunctions();
            
            function.AddCustomers();
            function.AddBankers();
            
            function.AddTellers();
        }
    }

}
