using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BankingCashCounter
{
    class QNode<T>
    {
        public T data;
        public QNode<T> next;
        /// <summary>
        /// variable intialization
        /// </summary>
        /// <param name="value"></param>
        public QNode(T value)
        {
            this.data = value;
            this.next = null;
        }
    }
}
