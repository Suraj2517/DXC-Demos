using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add("Hello");
            list.Add(2.5f);
            list.Add(true);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            list.Insert(2, "World");

            Console.WriteLine("After Insert");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(list.Count);

            ArrayList list1 = new ArrayList();
            list1.Add(10);
            list1.Add(20);
            list1.Add("Hello");
            list1.Add(2.5f);
            list1.Add(true);

            Console.WriteLine(list1[2]);

            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);

            Console.WriteLine(s.Contains(30));

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("After Remove with Pop Method");
            Console.WriteLine($"{s.Pop()} is popped out");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            Console.WriteLine("After removing");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            SortedList list2 = new SortedList();
            list2.Add(4, "Four");
            list2.Add(1, "One");
            list2.Add(3, "Three");
            list2.Add(2, "Two");
            list2.Add(5, "Five");

            Console.WriteLine(list2[3]);
            Console.WriteLine(list2.GetKey(1));

            foreach (var item in list2.Keys)
            {
                Console.WriteLine($"Key: {item}, Value: {list2[item]}");
            }

        }
    }
}