
using DataStructure.BalancedParantheses;
using DataStructure.BankingCashCounter;
using DataStructure.OrderedList;
using DataStructure.UnorderedList;
using System;
using System.IO;

namespace DataStructure
{
    class Program
    {
        /// <summary>
        /// invoke the all classes
        /// </summary>
        public static void InvokeClass()
        {
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1: Unordered List");
                Console.WriteLine("2: Ordered List");
                Console.WriteLine("3: Balanced Parantheses");
                Console.WriteLine("3: Banking Cash Counter");
                Console.WriteLine("0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Have a nice day!");
                        CONTINUE = false;
                        break;
                    case 1:
                        LinkedLists<string> linkedList = new LinkedLists<string>();
                        string filePath = @"V:\BridgeLabz\DataStructure\DataStructure\UnorderedList\UnorderedList.txt";
                        string text = File.ReadAllText(filePath);
                        string[] textArray = text.Split(" ");
                        for (int i = 0; i < textArray.Length; i++)
                        {
                            linkedList.AddLast(textArray[i]);
                        }
                        Console.WriteLine("Enter the word to be searched");
                        string word = Console.ReadLine();
                        int key = linkedList.Search(word);
                        if (key == 1)
                            linkedList.Pop(word);
                        else
                            linkedList.AddLast(word);
                        Console.WriteLine("List of words in the file");
                        string modifiedText = linkedList.Display();
                        File.WriteAllText(filePath, modifiedText);
                        Console.WriteLine("List of words after modification");
                        Console.WriteLine(modifiedText);
                        break;
                    case 2:
                        OrderedList<string> ordered = new OrderedList<string>();
                        string filePath1 = @"V:\BridgeLabz\DataStructure\DataStructure\OrderedList\OrderedList.txt";
                        string text1 = File.ReadAllText(filePath1);
                        string[] textArray1 = text1.Split(" ");
                        for (int i = 0; i < textArray1.Length; i++)
                        {
                            ordered.Add(textArray1[i]);
                        }
                        Console.WriteLine("Enter the number to be searched");
                        string num = Console.ReadLine();
                        bool rs = ordered.Search(num);
                        if (rs == true)
                            ordered.Pop(num);
                        else
                            ordered.Add(num);
                        string newList = ordered.Display();
                        File.WriteAllText(filePath1, newList);
                        Console.WriteLine("List of numbers after modification");
                        Console.WriteLine(newList);
                        break;
                    case 3:
                        bool expression = BalanceParantheses.CheckParantheses();
                        if (expression == true)
                            Console.WriteLine("Arithmetic Expression is balanced");
                        else
                            Console.WriteLine("Arithmetic Expression not is balanced");
                        break;
                      case 4:
                        Console.WriteLine("BankingCashConuter");
                        BankAccount account;
                        LinkedLists<BankAccount> accountList = new LinkedLists<BankAccount>();
                        CashCounter cashCounter = new CashCounter();
                        // CashCounterQueue<BankAccount> cashCounterQueue = new CashCounterQueue<BankAccount>();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Enter account holder name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("enter amount:");
                            int amount = Convert.ToInt32(Console.ReadLine());
                            account = new BankAccount(name, amount);
                            accountList.AddLast(account);
                            //cashCounter.SelectChoice(accountList);
                        }
                        foreach (BankAccount i in accountList)
                        {
                            Console.WriteLine("Account holder:{0}   balance:{1}", i.accHolderName, i.amount);
                        }
                        break;
                    default:
                        Console.WriteLine("Thank you! Select a valid option.");
                        break;
                }
            }
        }
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Program.InvokeClass();
        }
    }
}
