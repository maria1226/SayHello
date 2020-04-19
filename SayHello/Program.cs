using System;

namespace SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            Account facebookAccount = new FacebookAccount("Maria");
            Console.WriteLine(facebookAccount.SayHello());

            Account facebookAccountBalance = new BankAccount(facebookAccount.Name, 200);
            Console.WriteLine(facebookAccountBalance.SayHello());


            Account instagramAccount = new InstagramAccount("Ivan");
            Console.WriteLine(instagramAccount.SayHello());

            Account instagramAccountBalance = new BankAccount(instagramAccount.Name, 300);
            Console.WriteLine(instagramAccountBalance.SayHello());



        }

    }
}
