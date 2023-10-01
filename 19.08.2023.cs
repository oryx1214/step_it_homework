// task1
// using System;
// class Program
// {
//     static void Swap<T>(ref T a, ref T b)
//     {
//         T temp = a;
//         a = b;
//         b = temp;
//     }
//     static void Main()
//     {
//         int num1 = 5, num2 = 10;
//         Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");
//         Swap(ref num1, ref num2);
//         Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
//         string str1 = "Hello", str2 = "World";
//         Console.WriteLine($"Before swapping: str1 = {str1}, str2 = {str2}");
//         Swap(ref str1, ref str2);
//         Console.WriteLine($"After swapping: str1 = {str1}, str2 = {str2}");
//     }
// }

// task2
// public class Queue<T> where T : IComparable<T>
// {
//     private List<T> items = new List<T>();
//     public int Count => items.Count;
//     public void Enqueue(T item)
//     {
//         items.Add(item);
//         items.Sort();
//     }
//     public T Dequeue()
//     {
//         if (items.Count == 0)
//             throw new InvalidOperationException("Queue is empty");
//
//         T frontItem = items[0];
//         items.RemoveAt(0);
//         return frontItem;
//     }
//     public T Peek()
//     {
//         if (items.Count == 0)
//             throw new InvalidOperationException("Queue is empty");
//
//         return items[0];
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Queue<int> queue = new Queue<int>();
//         queue.Enqueue(5);
//         queue.Enqueue(2);
//         queue.Enqueue(8);
//         queue.Enqueue(1);
//         Console.WriteLine("Priority Queue:");
//         while (queue.Count > 0)
//         {
//             Console.WriteLine(queue.Dequeue());
//         }
//         Queue<string> stringQueue = new Queue<string>();
//         stringQueue.Enqueue("bmw");
//         stringQueue.Enqueue("tesla");
//         stringQueue.Enqueue("opel");
//         Console.WriteLine("\nString priority queue:");
//         while (stringQueue.Count > 0)
//         {
//             Console.WriteLine(stringQueue.Dequeue());
//         }
//     }
// }

// task3
// public class Queque<T> where T : IComparable<T>
// {
//     private List<T> items = new List<T>();
//     private int front = 0;
//     private int rear = -1;
//     private int count = 0;
//     public int Count => count;
//
//     public void Enqueue(T item)
//     {
//         if (count == items.Count)
//         {
//             items.Add(item);
//         }
//         else
//         {
//             rear = (rear + 1) % items.Count;
//             items[rear] = item;
//         }
//         count++;
//     }
//     public T Dequeue()
//     {
//         if (count == 0)
//             throw new InvalidOperationException("Queue is empty");
//
//         T frontItem = items[front];
//         front = (front + 1) % items.Count;
//         count--;
//         return frontItem;
//     }
//     public T Peek()
//     {
//         if (count == 0)
//             throw new InvalidOperationException("Queue is empty");
//
//         return items[front];
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Queque<int> queue = new Queque<int>();
//         queue.Enqueue(5);
//         queue.Enqueue(2);
//         queue.Enqueue(8);
//         queue.Enqueue(1);
//         Console.WriteLine("Circular queue:");
//         while (queue.Count > 0)
//         {
//             Console.WriteLine(queue.Dequeue());
//         }
//         Queque<string> stringQueue = new Queque<string>();
//         stringQueue.Enqueue("bmw");
//         stringQueue.Enqueue("tesla");
//         stringQueue.Enqueue("opel");
//         Console.WriteLine("\nString circular queue:");
//         while (stringQueue.Count > 0)
//         {
//             Console.WriteLine(stringQueue.Dequeue());
//         }
//     }
// }
