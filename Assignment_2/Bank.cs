using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;


        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
        }

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    Address s1 = new Address();
                    myBank[i] = account;
                    Console.WriteLine("Enter Account Name: \n");
                    myBank[i].AccountName = Console.ReadLine();
                    Console.WriteLine("Enter Your Address: \n");
                    Console.WriteLine("   Enter Your Hourse No.: ");
                    account.Address.HouseNo = Console.ReadLine();
                    Console.WriteLine("   Enter Your Road No.: ");
                    account.Address.RoadNo = Console.ReadLine();
                    Console.WriteLine("   Enter Your City: ");
                    account.Address.City = Console.ReadLine();
                    Console.WriteLine("   Enter Your Country No.: ");
                    account.Address.Country = Console.ReadLine();
                    int x = myBank[i].Print();
                    Console.WriteLine(x);
                    break;
                }
            }
        }

        public void Deleteccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Congratulations!!! Your Account is successfully Deleted\n");

                    for (int j = i; j < myBank.Length - 1; j++)
                    { 
                        myBank[j] = myBank[j + 1];
                    }
                }
            }
        }

    }
}
