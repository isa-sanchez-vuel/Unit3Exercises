using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_OOPMultiBankAccount
{
    internal class Account
    {
        string accountNumber;
        string pin;
        string ownerName;

        List<Movement> movements = new();
        string iban;

        public Account(string id, string pin, string owner) 
        {
            accountNumber = id;
            this.pin = pin;
            ownerName = owner;
        }

        public void CreateIban(string country, string bankId, string bankControl, string sucursal)
        {
            iban = country + bankControl + bankId + sucursal + bankControl + accountNumber;
        }

    }
}
