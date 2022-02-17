using System;
using System.Collections.Generic;
using System.Text;

namespace MyStackTask
{
    class MyStack<T>
    {
        private T[] elements;
        private int count;
        const int n = 10;

        public MyStack(int length)
        {
            elements = new T[length];
        }
        public MyStack()
        {
            elements = new T[n];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get { return count; }
        }

        public T[] MyArray
        {
            get { return elements; }
        }
        public void Push(T item)
        {
            if (count == elements.Length)
                throw new StackOverflowException("Переполнение стека");
            elements[count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("Стек пуст");
            T item = elements[--count];
            elements[count] = default(T);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("Стек пуст");
            return elements[count - 1];
        }
    }
}
