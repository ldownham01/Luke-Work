using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Account class
            Account myAccount = new Account();
            double currentAmount = 0.0;
            //Save money in current account
            currentAmount = myAccount.setAccountBalance(1000.00);
            Console.WriteLine("current ammount : {0}", currentAmount);

            //Witdraw 200.00
            currentAmount = myAccount.withdrawFromAccount(200.00);
            Console.WriteLine("current ammount : {0}", currentAmount);

            //Get balance
            currentAmount = myAccount.getAccountBalance();
            Console.WriteLine("current ammount : {0}", currentAmount);
            Console.ReadLine();
        }
    }
}
