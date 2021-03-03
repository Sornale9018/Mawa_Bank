using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Mawa's Bank", 100);
            Console.WriteLine("Welcome to the " + ourBank.BankName + "'s System");

            //Console.Write("Enter Your Choice");

            bool mawa = true;
            while (mawa)
            {
                ourBank.Operation();

                int mawaa = Convert.ToInt32(Console.ReadLine());
                switch (mawaa)
                {
                    case 1:

                        Account a1 = new Account(new Address());
                        ourBank.AddAccount(a1);
                        break;


                    case 2:
                        ourBank.Transaction(2);
                        break;

                    case 3:
                        ourBank.Transaction(3);
                        break;

                    case 4:
                        ourBank.Transaction(4);
                        break;

                    case 5:

                        //ourBank.Deleteccount(accountNumber);
                        break;

                    case 6:
                        ourBank.PrintAllAccount();
                        break;

                    case 7:
                        mawa = false;
                        break;

                    default:
                        break;


                }
            }
        }
    }
}
