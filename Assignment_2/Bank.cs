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

                    Console.WriteLine("Enter your Birth Date: ");
                    myBank[i].Date = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Birth Month: ");
                    myBank[i].Month = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your Birth Year: ");
                    myBank[i].Year = Convert.ToInt32(Console.ReadLine());

                    myBank[i].PrintDateOfBirth();

                    Console.WriteLine("Enter Your Address: \n");

                    Console.WriteLine("   Enter Your Hourse No.: ");
                    account.Address.HouseNo = Console.ReadLine();

                    Console.WriteLine("   Enter Your Road No.: ");
                    account.Address.RoadNo = Console.ReadLine();

                    Console.WriteLine("   Enter Your City: ");
                    account.Address.City = Console.ReadLine();

                    Console.WriteLine("   Enter Your Country No.: ");
                    account.Address.Country = Console.ReadLine();

                    int x = myBank[i].PrintAccountNumber();
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


        public void Transaction(int s, params int[] ab)
        {
            Account a2 = new Account();
            if (s == 2)
            {
                if (s == 2)
                {


                    Console.WriteLine("Enter Your Account Number to Withdraw");
                    int accountNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter The Amount You want to Withdraw: ");

                    double x = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (accountNum == myBank[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < myBank.Length; i++)
                            {
                                if (myBank[i] == null)
                                {
                                    continue;
                                }
                                else if (myBank[i].AccountNumber == accountNum)
                                {
                                    myBank[i].Withdraw(x);
                                    flag = 0;
                                    break;
                                }
                                else
                                {
                                    flag = 1;
                                }

                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Account not found");
                                // Console.WriteLine("Exit the System & Try Again");
                            }
                        }


                        break;
                    }

                }


                if (s == 1)
                {


                    Console.WriteLine("Enter Your Account Number to Deposit");
                    int accountNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter The Amount You want to Deposit: ");

                    double x = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (accountNum == myBank[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < myBank.Length; i++)
                            {
                                if (myBank[i] == null)
                                {
                                    continue;
                                }
                                else if (myBank[i].AccountNumber == accountNum)
                                {

                                    myBank[i].Deposit(x);
                                    flag = 2;
                                    break;
                                }
                                else
                                {
                                    flag = 1;
                                }
                                break;

                            }
                            if (flag == 1)
                            {
                                Console.WriteLine("Account not found");
                                Console.WriteLine("Exit the System & Try Again");
                            }
                            if (flag == 2)
                                Console.WriteLine("Deposited");
                        }
                        break;
                    }



                }

                if (s == 3)
                {
                    Console.WriteLine("Enter Your Account Number");
                    int accountNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter The Account Number Where you want to Transfer");
                    int accountTransNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter The Amount You want to Transfer: ");

                    double x = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (accountNum == myBank[i].AccountNumber && accountTransNum == myBank[i].AccountNumber)
                        {
                            int flag = 0;
                            for (i = 0; i < myBank.Length; i++)
                            {
                                if (myBank[i] == null)
                                {
                                    continue;
                                }
                                else if (myBank[i].AccountNumber == accountNum)
                                {
                                    for (int j = 0; j < myBank.Length; j++)
                                    {
                                        if (myBank[j].AccountNumber == accountTransNum)
                                        {
                                            myBank[i].Transfer(myBank[j], x);
                                            flag = 0;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    flag = 1;
                                }

                            }
                            if (flag == 1)
                                Console.WriteLine("Account not found");
                            Console.WriteLine("Exit the System & Try Again");
                        }

                        break;
                    }


                }
            }

        }

        public void PrintAllAccount()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
                myBank[i].PrintAccountNumber();
            }
        }

        /* public void Operation()
         {
             Console.WriteLine("Choose Service from the Below Option");
             Console.WriteLine("1. Create an Account");
             Console.WriteLine("2. Withdraw Balance");
             Console.WriteLine("3. Deposit Balance");
             Console.WriteLine("4. Transfer Balance");
             Console.WriteLine("5. Delete Account");
             Console.WriteLine("6. Show Account Details ");

             Console.WriteLine("\n");


         }*/

        public void Operation()
        {
            Console.WriteLine("Choose Service from the Below Option");
            Console.WriteLine("1. OPEN");
            Console.WriteLine("2. Account");
            Console.WriteLine("3. Exit");
            

            Console.WriteLine("\n");


        }

    }
}
