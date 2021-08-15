using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BankingCashCounter
{
    class CashCounter
    {
        Queue<string> queue = new Queue<string>();

        public void SelectChoice(LinkedList<BankAccount> banks)
        {
            string name = queue.Dequeue();
            //// amount
            BankAccount account = null;
            foreach (BankAccount i in banks)
            {
                if (i.accHolderName.Equals(name))
                {
                    account = i;
                }
            }
            Console.WriteLine("Enter 1.Deposit\n2.Withdraw");
            Console.Write("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amount to deposit:");
                    int amt = Convert.ToInt32(Console.ReadLine());
                    UpdateChange(account, amt, banks, name, choice);
                    break;
                case 2:
                    Console.WriteLine("Enter amount to withdraw:");
                    int amt1 = Convert.ToInt32(Console.ReadLine());
                    if (account.amount > amt1 && account != null)
                    {
                        UpdateChange(account, amt1, banks, name, choice);

                    }
                    else
                    {
                        Console.WriteLine("Balance not available!");
                    }
                    break;
            }
        }

        public static void UpdateChange(BankAccount bank, int amount, LinkedList<BankAccount> bankAccounts, 
                                        string name, int choice)
        {
            if (bank == null)
            {
                BankAccount bank1 = new BankAccount(name, amount);
                bankAccounts.AddLast(bank1);
            }
            else if (choice == 1)
            {
                bank.amount += amount;
            }
            else
            {
                bank.amount -= amount;
            }
        }
    }
}
