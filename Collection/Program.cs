using System;
using System.Collections;

namespace CollectionsExample
{
    class CollectionExample
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("Akira");
            queue.Enqueue("Iyanah");

            Console.WriteLine("---------Queue---------");
            Console.WriteLine("queue containing:");
            foreach (string name in queue)
            Console.Write(name + "\n");

            Console.WriteLine();

            //adding usernames
            queue.Enqueue("Priya");
            queue.Enqueue("janani");

            Console.WriteLine("Updated queue: ");
            foreach (string name in queue)
            Console.Write(name + "\n");

            Console.WriteLine();
            Console.WriteLine("Removing userNames:");

            string change = (string)queue.Dequeue();
            Console.WriteLine("The removed value: {0}", change);

            change = (string)queue.Dequeue();
            Console.WriteLine("The removed value: {0}", change);

        
        }
    }
}