﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class Queue<T>: IEnumerable<T>
    {
        private const int DefaultSize = 10;
        private T[] _items;
        private int _tail;

        public Queue()
        {
            _items = new T[DefaultSize];
            _tail = -1;
        }

        // Add an item into a queue.
        public void Enqueue(T item)
        {
            if (_tail + 1 == _items.Length)
                Array.Resize(ref _items, _items.Length*2);
            _items[++_tail] = item;
        }

        // Returns an item from a queue with removing it.
        public T Dequeue()
        {
            if (_tail == -1)
                throw new Exception("Queue is empty!");
            T temp = _items[0];
            for (int i = 0; i < _tail; i++)
                _items[i] = _items[i + 1];
            _items[_tail--] = default(T);
            return temp;
        }

        // Returns an item from a queue without removing it.
        public T Peek()
        {
            return _items[_tail];
        }

        // Delete all the items in a queue.
        public void Clear()
        {
            for (int i = 0; i < _tail + 1; i++)
            {
                _items[i] = default(T);
            }
            _tail = -1;   
        }

        // Print a queue.
        public void Print()
        {
            foreach(T item in this)
                Console.WriteLine(item.ToString());
        }

        // IEnumerable<T> realization.
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _tail + 1; i++)
            {
                yield return _items[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
