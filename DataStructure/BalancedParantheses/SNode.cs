using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BalancedParantheses
{
    class SNode<T>
    {
        public T data;
        public SNode<T> next;
        /// <summary>
        /// variable initialization
        /// </summary>
        /// <param name="value"></param>
        public SNode(T value)
        {
            this.data = value;
            this.next = null;
        }
    }
}
