using System;

namespace BankingCashOpearation
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            AddPerson addPerson = new AddPerson();           
            addPerson.Add();
            Console.WriteLine("Do you want to continue with transcation ? (Yes/No)");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                addPerson.Transaction();
            }
            else
            {
                Console.WriteLine("Thank you");
            }
            
        }
    }
}
