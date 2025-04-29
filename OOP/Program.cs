using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OOP;



namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////POLYMORPHISM -> ABILITY OF AN OBJECT WHICH TAKE MANY FORMS
            Car car = new Car();

            car.Start();

            Console.WriteLine(car.VehicleType);

            ////INHERITANCE
            //Bike bike = new Bike();
            //bike.Start();


            ////ABSTRACTION
            ////REDUCE COMPLEXITY BY HIDING UNNECESSARY DETAILS
            //EmailService emailService = new EmailService();
            //emailService.SendEmail();


            ////ENCAPSULATION
            //BadBankAccounts badAccount = new BadBankAccounts();
            //badAccount.Deposit(100);

            //Console.WriteLine(badAccount.getBalance());
            //Console.WriteLine(badAccount.Deposit(1000));
            //Console.WriteLine(badAccount.getBalance());

            //Console.WriteLine(badAccount.Withdraw(-20000));
            Console.ReadLine();
        }
    }
}
