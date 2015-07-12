﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");
            numbers.Enqueue("six");
            numbers.Dequeue();
           
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Print();
        }
    }
}
