using System;
using System.Collections.Generic;
using System.Text;

namespace SayHello
{
    class BankAccount: Account
    {

        public BankAccount() { }
        public BankAccount(string Name,int Balance)
            : base(Name)
        {
            this.Balance = Balance;
        }
        
        public int Balance { get; set; }


        public override string SayHello()
        {
          return $"{Name}'s account balance is {Balance} lv .";
        }


    }
}
