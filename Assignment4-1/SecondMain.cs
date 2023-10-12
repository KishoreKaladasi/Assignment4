using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4Library;
using static Assignment4Library.BankTransactions;

namespace Assignment4_1
{
    internal class SecondMain
    {
        static void Main (String[] args)
        { 
            BankTransactions.Bank B = new BankTransactions.Bank();
            Bank bank = new Bank();
            bank.AccountNo = 37570696888;
            bank.BranchName = "Kolkata";
            bank.DepositAmount = 10000;
            bank.DepositDate = new DateTime(2022, 05, 10);
            bank.WithdrawAmount = 1000;
            bank.WithdrawDate = new DateTime(2023, 06, 12);
            bank.Deposit(bank.DepositAmount, bank.DepositDate, bank.BranchName, bank.AccountNo);
            bank.WithDraw(bank.WithdrawAmount, bank.WithdrawDate, bank.BranchName, bank.AccountNo);
            Console.ReadLine();


        }
    }
}
