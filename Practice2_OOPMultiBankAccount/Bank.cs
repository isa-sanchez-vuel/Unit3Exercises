using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_OOPMultiBankAccount
{
    internal class Bank
    {
        string name;
        string bankId;
        List<Account> accounts = new();

        public Bank(string name, string id) 
        {
            this.name = name;
            bankId = id;
        }
    }
}
