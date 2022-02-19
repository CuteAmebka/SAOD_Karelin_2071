using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTask
{
    class MyQueue<T>
    {
        private int SIZE = 5; 
        private int currentOut, currentIn;
        private T[] items;

        public MyQueue()
        {
            currentOut = -1;
            currentIn = -1;
            items = new T[SIZE];
        }

        public T[] MyArray()
        {
            return items;
        }
        bool isFull()
        {
            if (currentOut == 0 && currentIn == SIZE - 1)
            {
                return true;
            }
            if (currentOut == currentIn + 1)
            {
                return true;
            }
            return false;
        }

        bool isEmpty()
        {
            if (currentOut == -1)
                return true;
            else
                return false;
        }


        public void enQueue(T element)
        {
            if (isFull())
            {
                throw new Exception("Очередь заполнена");
            }
            else
            {
                if (currentOut == -1)
                    currentOut = 0;
                currentIn = (currentIn + 1) % SIZE;
                items[currentIn] = element;
            }
        }

        // Удаление элемента
        public T deQueue()
        {
            T element;
            if (isEmpty())
            {
                throw new Exception("Очередь пуста");
            }
            else
            {
                element = items[currentOut];
                if (currentOut == currentIn)
                {
                    items[currentOut] = default(T);
                    currentOut = -1;
                    currentIn = -1;
                } 
                else
                {
                    items[currentOut] = default(T);
                    currentOut = (currentOut + 1) % SIZE;
                }
                return (element);
            }
        }
        public T Peek()
        {
            if (isEmpty())
            {
                throw new Exception("Очередь пуста");
            }
            else
            {
                return (items[currentOut]);
            }
        }
    }
}
