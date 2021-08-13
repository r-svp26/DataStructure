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
                Console.WriteLine("0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LinkedList<string> linkedList = new LinkedList<string>();
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
                    case 0:
                        Console.WriteLine("Have a nice day!");
                        CONTINUE = false;
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
