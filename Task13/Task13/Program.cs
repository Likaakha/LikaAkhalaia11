using System.Collections;

namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. ArrayList
            Console.WriteLine("ArayList:");
            ArrayList arraylist = new ArrayList();
            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Insert(2, 10);
            arraylist.Remove(1);

            foreach (var list1 in arraylist)
            {
                Console.WriteLine(list1);
            }



            // 2. List<T>
            Console.WriteLine("List<T> :");
            List<int> list = new List<int> { 10, 20, 30 };
            list.AddRange(new int[] { 40, 50 }); 
            list.Sort(); 
            list.RemoveAt(2); 
            foreach (var num in list)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // 3. Dictionary<TKey, TValue>
            Console.WriteLine("Dictionary<TKey, TValue>:");
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);
            dictionary.Remove("Two"); 
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"Key: {key}, Value: {dictionary[key]}");
            }
            Console.WriteLine();

            // 4. SortedList<TKey, TValue>
            Console.WriteLine("SortedList<TKey, TValue>:");
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(2, "Two");
            sortedList.Add(1, "One");
            sortedList.Add(3, "Three");
            sortedList.RemoveAt(0); 
            foreach (var key in sortedList.Keys)
            {
                Console.WriteLine($"Key: {key}, Value: {sortedList[key]}");
            }
            Console.WriteLine();

            // 5. Stack<T>
            Console.WriteLine("Stack<T>:");
            Stack<string> stack = new Stack<string>();
            stack.Push("Lika");
            stack.Push("Nika");
            stack.Push("Bili");
            Console.WriteLine($"Lifo Peek: {stack.Peek()}");
            stack.Pop(); // Remove the top element
            foreach (var name in stack)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // 6. Queue<T>
            Console.WriteLine("Queue<T>:");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine($"Fifo Peek: {queue.Peek()}");
            queue.Dequeue(); 
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // 7. SortedDictionary<TKey, TValue>
            Console.WriteLine("SortedDictionary<TKey, TValue>:");
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            sortedDictionary.Add(3, "Three");
            sortedDictionary.Add(7, "Seven");
            sortedDictionary.Add(5, "Five");
            sortedDictionary.Remove(2);
            foreach (var key in sortedDictionary.Keys)
            {
                Console.WriteLine($"Key: {key}, Value: {sortedDictionary[key]}");
            }
            Console.WriteLine();

            // 8. HashSet<T>
            Console.WriteLine("HashSet<T>:");
            HashSet<int> hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(2); 
            hashSet.Add(3);
            HashSet<int> anotherSet = new HashSet<int> { 3, 4, 5 };
            hashSet.UnionWith(anotherSet);
            foreach (var item in hashSet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            
        }
    }

}
    

