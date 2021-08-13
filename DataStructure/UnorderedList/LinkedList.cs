using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.UnorderedList
{
    public class LinkedList<T>
    {
        private Node<T> head;
        /// <summary>
        /// add the words
        /// </summary>
        /// <param name="value"></param>
        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
            }
            //// iterate till the last element and make next field of last element as newNode.
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        /// <summary>
        /// search word from linked list.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>count</returns>
        public int Search(T value)
        {
            Node<T> root = this.head;
            int count = 0;
            while (root != null)
            {
                if (root.data.Equals(value))
                {
                    return count;
                }
                root = root.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// remove the first element from linkedlist.
        /// </summary>
        /// <returns></returns>
        public void Pop(T value)
        {
            if (head == null)
            {
                Console.WriteLine("No element to delete");
            }
            else if (head.data.Equals(value))
            {
                head = head.next;
            }
            else
            {
                Node<T> prev = head;
                Node<T> temp = head;

                while (temp != null && !(temp.data.Equals(value)))
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp.data.Equals(value))
                {
                    prev.next = temp.next;
                    temp.next = null;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            if (head == null)
            {
                return 0;
            }
            else
            {
                Node<T> temp = head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
            }
        }
        /// <summary>
        /// display the words of linkedlist
        /// </summary>
        internal string Display()
        {
            Node<T> temp = head;
            string data = "";
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data +" ");
                    data = data + temp.data + " ";
                    temp = temp.next;
                }
                data += temp.data;
            }
            Console.WriteLine();
            return data;
        }
    }
}
