using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BalancedParantheses
{
    class Stack<T>
    {
        private SNode<T> top;
        /// <summary>
        /// constructor is used to initialized the top.
        /// </summary>
        public Stack()
        {
            this.top = null;
        }
        /// <summary>
        /// add the elements.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            SNode<T> newNode = new SNode<T>(value);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }
        /// <summary>
        /// remove the elements from stack.
        /// </summary>
        /// <returns></returns>
        public bool Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return false;
            }
            else
            {
                top = top.next;
                return true;
            }
        }
        /// <summary>
        /// stack is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
    }
}
