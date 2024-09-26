using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola_doble_en_arreglo
{
    internal class Deque
    {
        private int[] deque;
        private int front, rear, size;
        private const int capacity = 5;

        public Deque()
        {
            deque = new int[capacity];
            front = -1;
            rear = 0;
            size = 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void InsertFront(int data)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Deque is full");
            }

            if (front == -1) // Si la cola está vacía
            {
                front = 0;
                rear = 0;
            }
            else
            {
                front = (front - 1 + capacity) % capacity; // Movimiento circular
            }

            deque[front] = data;
            size++;
        }

        public void InsertRear(int data)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Deque is full");
            }

            if (front == -1) // Si la cola está vacía
            {
                front = 0;
                rear = 0;
            }
            else
            {
                rear = (rear + 1) % capacity; // Movimiento circular
            }

            deque[rear] = data;
            size++;
        }

        public int DeleteFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Deque is empty");
            }

            int data = deque[front];
            front = (front + 1) % capacity;
            size--;

            if (size == 0)
            {
                front = -1;
                rear = 0;
            }

            return data;
        }

        public int DeleteRear()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Deque is empty");
            }

            int data = deque[rear];
            rear = (rear - 1 + capacity) % capacity;
            size--;

            if (size == 0)
            {
                front = -1;
                rear = 0;
            }

            return data;
        }

        public string Display()
        {
            if (IsEmpty())
            {
                return "Deque is empty";
            }

            string result = "Deque: ";
            int i = front;
            for (int count = 0; count < size; count++)
            {
                result += deque[i] + " ";
                i = (i + 1) % capacity;
            }
            return result.Trim();
        }
    }
}
