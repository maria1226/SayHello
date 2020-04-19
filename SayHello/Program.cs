using System;
//Да се създаде абстрактен клас Accounts и метод  SayHello в него.
//Метод SayHello(), който отпечатва поздравително съобщение за собственика на акаунта.
//Да се направят и наследници на този клас - FacebookAccounts и InstagramAccounts.
//Да се пренапише метода SayHello() от родителския клас. 
//("Добре дошъл в Facebook/Instagram  ,{name}!")
//Да се направи трети наследник - BankAccount, в който да се пренапише метода SayHello()
//и да се направи собствен метод, който отпечатва наличността по сметката на потребителя.
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
