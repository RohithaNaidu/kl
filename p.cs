using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List<T>
        List<string> stringList = new List<string>();
        stringList.Add("Apple");
        stringList.Add("Banana");
        stringList.Add("Orange");

        Console.WriteLine("List of Fruits:");
        foreach (string fruit in stringList)
        {
            Console.WriteLine(fruit);
        }

        // Dictionary<TKey, TValue>
        Dictionary<int, string> idToName = new Dictionary<int, string>();
        idToName.Add(1, "John");
        idToName.Add(2, "Jane");
        idToName.Add(3, "Bob");

        Console.WriteLine("\nDictionary of IDs to Names:");
        foreach (var pair in idToName)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }

        // Queue<T>
        Queue<string> stringQueue = new Queue<string>();
        stringQueue.Enqueue("First");
        stringQueue.Enqueue("Second");
        stringQueue.Enqueue("Third");

        Console.WriteLine("\nQueue of Strings:");
        while (stringQueue.Count > 0)
        {
            Console.WriteLine(stringQueue.Dequeue());
        }

        // Stack<T>
        Stack<string> stringStack = new Stack<string>();
        stringStack.Push("First");
        stringStack.Push("Second");
        stringStack.Push("Third");

        Console.WriteLine("\nStack of Strings:");
        while (stringStack.Count > 0)
        {
            Console.WriteLine(stringStack.Pop());
        }
    }
}