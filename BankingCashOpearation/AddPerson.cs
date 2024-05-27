using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace BankingCashOpearation
{
    internal class AddPerson
    {
        static int amount = 1000;
        Queue queue = new Queue();
        public void Add()
        {            
            while (true)
            {
                Console.WriteLine("Enter the person name:");
                string name = Console.ReadLine();               
                queue.EnQueue(name);                

                Console.Write("Do you want to add another Person? (Yes/No): ");
                string response = Console.ReadLine().ToLower();
                
                if (response != "yes")
                {
                    break;
                }
            }
            queue.ViewQueue();
        }

        public void Transaction()
        {
            Find:
                                           
            var FirstPersonOfQueue = queue.Find();
            if (FirstPersonOfQueue!= null)
            {
                while (true)
                {
                    int option = 0;
                    Console.WriteLine();
                    Console.WriteLine("1.Deposit");
                    Console.WriteLine("2.Withdraw");
                    Console.WriteLine("please select the opetion:");
                    try
                    {
                         option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }                    
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the amount to deposit:");
                            int depositAmount = Convert.ToInt32(Console.ReadLine());
                            amount += depositAmount;
                            Console.WriteLine();
                            Console.WriteLine(depositAmount+" is deposited.");
                            break;

                        case 2:
                            Console.WriteLine("Enter withdraw amount:");
                            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                            if (amount >= withdrawAmount && amount > 0)
                            {
                                amount -= withdrawAmount;
                                Console.WriteLine(withdrawAmount + " is withdrawn.");
                            }
                            else
                            {
                                Console.WriteLine("Dont have enough balance.");
                            }
                            break;
                        default:
                            Console.WriteLine("wrong option");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Do you want to continue another transaction? (Yes/ No): ");
                    string response = Console.ReadLine().ToLower();

                    if (response != "yes")
                    {
                        break;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("ThanK You! for banking your final amount is " + amount);
                queue.Dequeue();
            }
            else
            {
                Console.WriteLine("User not found!");                
            }           
            
            goto Find;
        }

    }
}
