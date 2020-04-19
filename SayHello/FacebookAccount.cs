using System;
using System.Collections.Generic;
using System.Text;

namespace SayHello
{
    class FacebookAccount:Account
    {
        public FacebookAccount() { }
        public FacebookAccount(string Name)
            : base (Name)
        {

        }
        public override string SayHello()
        {
            return $"Welcome to Facebook,{Name}!";
        }


    }
}
