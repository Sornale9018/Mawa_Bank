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
                
                string mawaa = Console.ReadLine();
                
                switch (mawaa)
                {
                    case "open":
                          
                            Account a1 = new Account(new Address());
                            ourBank.AddAccount(a1);
                            break;
                        
                    case "account":
                                                                      
                        bool mawaaa = true;
                        while (mawaaa)
                        {
                            ourBank.Operations();
                            string mawa2 = Console.ReadLine();

                            //mawa = false;
                            switch (mawa2)
                            {

                                case "deposit":
                                    {
                                        ourBank.Transaction(1);

                                        break;    
                                    }
                                    
                                    
                                case "withdraw":
                                    {
                                        ourBank.Transaction(2);
                                        break;
                                    }
                                case "transfer":
                                    {
                                        ourBank.Transaction(3);
                                        break;
                                    }

                                case "show":
                                    ourBank.PrintAllAccount();
                                    break;

                                case "change":
                                    {
                                        Account a2 = new Account(new Address());
                                        ourBank.AddAccount(2,a2);
                                        break;
                                    }
                                case "quit":
                                    mawaaa = false;
                                    break;

                            }
                            

                        }
                               break;


                       case "quit":
                        mawa = false;
                        break;
                        
                        
                       


                                        


                    


                }
            }
        }
    }
}
