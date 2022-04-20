using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class MyBankAccount
    {
        public string Number  { get; }
        public  string Owner { get; set; }
        public decimal Balance  { get; }

        public MyBankAccount(string name, decimal initialBalance) 
        {
            this.Owner = name;
            this.Balance = initialBalance;
        }
    }
}
