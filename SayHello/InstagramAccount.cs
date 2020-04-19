using System;
using System.Collections.Generic;
using System.Text;

namespace SayHello
{
    class InstagramAccount:Account
    {
        public InstagramAccount() { }
        public InstagramAccount(string Name)
            : base(Name)
        {

        }
        public override string SayHello()
        {
            return $"Welcome to Instagram,{Name}!";
        }


    }
}
