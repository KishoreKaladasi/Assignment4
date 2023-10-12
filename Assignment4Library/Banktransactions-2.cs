using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Library
{
    public class BankTransactions
    {
        public class Bank 
        {

            public float DepositAmount { get; set; }
            public DateTime DepositDate { get; set; }
            public string BranchName { get; set; }
            public long AccountNo { get; set; }
            public DateTime WithdrawDate { get; set; }
            public float WithdrawAmount { get; set; }

            public void Deposit(float amt,DateTime depositDate,string branchName,long AccNo)
            {
                DepositAmount = amt;    
                DepositDate = depositDate;
                BranchName = branchName;
                AccountNo = AccNo;
                Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Deposit Amount: " + DepositAmount + " Deposit Date: " + DepositDate);


            }

            public void Deposit(long AccNo,float amt, DateTime depositDate, string branchName)
            {
                DepositAmount = amt;
                DepositDate = depositDate;
                BranchName = branchName;
                AccountNo = AccNo;
                Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Deposit Amount: " + DepositAmount + " Deposit Date: " + DepositDate);


            }

            public void Deposit(long AccNo, float amt, DateTime depositDate)
            {
                DepositAmount = amt;
                DepositDate = depositDate;                
                AccountNo = AccNo;
                Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Deposit Amount: " + DepositAmount + " Deposit Date: " + DepositDate);

            }
            public void WithDraw(float amt, DateTime depositDate, string branchName, long AccNo)
            {
                DepositAmount = amt;
                DepositDate = depositDate;
                BranchName = branchName;
                AccountNo = AccNo;
                Console.WriteLine("Account No: " + AccountNo + " Branch Name: " + BranchName + " Withdraw Amount: " + WithdrawAmount + " Withdraw Date: " + WithdrawDate);
            }

        }

            



       
        
    }
}
