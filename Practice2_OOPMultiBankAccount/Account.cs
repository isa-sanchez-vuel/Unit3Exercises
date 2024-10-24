using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_OOPMultiBankAccount
{
    internal class Account
    {
        string accountId;
        string pin;
        string ownerName;
        List<Movement> movements = new();

        public Account(string id, string pin, string owner) 
        {
            accountId = id;
            this.pin = pin;
            ownerName = owner;
        }
    }
}
