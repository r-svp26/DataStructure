using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.UnorderedList
{
    class Node<T>
    {
        // variables
        public T data;
        public Node<T> next;
        /// <summary>
        /// constructor is used to initialized the data.
        /// </summary>
        /// <param name="data"></param>
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
