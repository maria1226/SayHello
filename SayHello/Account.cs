using System;
using System.Collections.Generic;
using System.Text;

namespace SayHello
{
    abstract class Account
    {
        public Account() { }
        public Account(string Name)
        {
            this.Name = Name;
        }
        public string Name { get; set; }

        public abstract string SayHello();
    }
}
