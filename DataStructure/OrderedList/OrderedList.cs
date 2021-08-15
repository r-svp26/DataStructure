using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.OrderedList
{
    class OrderedList<T> where T : IComparable
    {
        public INode<T> head;
        /// <summary>
        /// add the element at first position
        /// </summary>
        /// <param name="newNode"></param>
        public void AddFirst(INode<T> newNode)
        {
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        /// <summary>
        /// add the number into list.
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            INode<T> node = new INode<T>(value);
            if (head == null)
            {
                AddFirst(node);
            }
            else if (head.data.CompareTo(value) >= 0)
            {
                AddFirst(node);
            }
            else
            {
                INode<T> temp = head;
                INode<T> prev = head;
                while (temp.next != null && temp.next.data.CompareTo(value) < 0)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp.next == null)
                {
                    temp.next = node;
                }
                else if (temp.next.data.CompareTo(value) > 0)
                {
                    node.next = temp.next;
                    temp.next = node;
                }
            }
        }
        /// <summary>
        /// search the number.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(T value)
        {
            if (head == null)
            {
                return false;
            }
            else
            {
                INode<T> temp = head;
                while (temp.next != null && !(temp.data.Equals(value)))
                {
                    temp = temp.next;
                }
                if (temp.data.Equals(value))
                {
                    return true;
                }
                return false;
            }
        }
        /// <summary>
        /// popout the number
        /// </summary>
        /// <param name="value"></param>
        public void Pop(T value)
        {
            if (head == null)
            {
                Console.WriteLine("Data not found");
            }
            else if (head.data.Equals(value))
            {
                head = head.next;
            }
            else
            {
                INode<T> prev = head;
                INode<T> temp = head;

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
        /// display the words of linkedlist
        /// </summary>
        internal string Display()
        {
            INode<T> temp = head;
            string data = "";
            if (head == null)
            {
                Console.WriteLine("No element in the list");
            }
            else
            {
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
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
