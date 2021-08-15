using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.BankingCashCounter
{
    class Queue<T>
    {
        private QNode<T> front;
        private QNode<T> rear;
        /// <summary>
        /// add element into queue
        /// </summary>
        /// <param name="value"></param>
        public void Enqueue(T value)
        {
            QNode<T> newNode = new QNode<T>(value);
            if (front == null)
            {
                front = newNode;
            }
            else
            {
                rear = front;
                while (rear.next != null)
                {
                    rear = rear.next;
                }
                rear.next = newNode;
            }
        }
        /// <summary>
        /// remove elements from queue
        /// </summary>
        /// <returns></returns>
        public string Dequeue()
        {
            rear = front;
            if (rear == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                front = front.next;
            }
            return rear.data.ToString();
        }

        public void Display()
        {
            rear = front;
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (rear != null)
                {
                    Console.WriteLine(rear.data +" ");
                    rear = rear.next;
                }
            }
        }
    }
}
