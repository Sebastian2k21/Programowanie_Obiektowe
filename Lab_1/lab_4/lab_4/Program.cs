using lab_4;
using System;
using System.Collections;
using System.Collections.Generic;

namespace lab_4
{
    class Program
    {

        static void Main(string[] args)
        {

            #region Zadanie2
            Console.WriteLine("\n\n===== IList =====\n\n");
            IList list = new ArrayList();

            list.Add("pies");
            list.Add("kot");
            list.Add(3);
            list.Add(4.5);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Lista zawiera : {list[i]}");
            }

            Console.WriteLine("\n\n==================\n\n");
            list.Remove("pies");

            foreach (var item in list)
            {
                Console.WriteLine($"Lista zawiera : {item}");
            }



            Console.WriteLine("\n\n===== SortedList =====\n\n");

            IDictionary dictionary1 = new SortedList(); // sortuje po kluczach alfabetycznie
            dictionary1.Add("Adam", 165);
            dictionary1.Add("Marysia2", 150);
            dictionary1.Add("Marysia", 190);
            dictionary1.Add("Marcel", 180);

            Console.WriteLine("Slownik zawiera:");
            foreach (DictionaryEntry item in dictionary1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            dictionary1.Remove("Marcel");
            Console.WriteLine("\n\n==================\n\n");

            foreach (DictionaryEntry item in dictionary1)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            Console.WriteLine("\n\n===== HashTable =====\n\n");
            IDictionary dictionary2 = new Hashtable();
            dictionary2.Add("Adam", 165);
            dictionary2.Add("Marysia2", 150);
            dictionary2.Add("Marysia", 190);
            dictionary2.Add("Marcel", 180);

            Console.WriteLine("Slownik zawiera:");
            foreach (DictionaryEntry item in dictionary2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            dictionary1.Remove("Marcel");
            Console.WriteLine("\n\n==================\n\n");

            foreach (DictionaryEntry item in dictionary2)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("\n\n===== Queue =====\n\n"); // kolejka jak w sklepie, pierwszy wchodzi i pierwszy wychodzi FIFO -> First In First Out
            Queue queue = new Queue();
            queue.Enqueue("Adam");
            queue.Enqueue("Marcin");
            queue.Enqueue("Krzysiu");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n====== PO SCIAGNIECIU ======n\n");

            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n\n===== Stack =====\n\n"); // LIFO -> Last In First Out
            Stack stack = new Stack();
            stack.Push("Adam");
            stack.Push("Marcin");
            stack.Push("Krzysiu");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n====== PO SCIAGNIECIU ======n\n");

            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine("------------------- ZADANIE 2 -------------------");

            #region Zadanie3



            Console.WriteLine("\n\n===== IList =====\n\n");
            IList<int> list1 = new List<int>();

            list1.Add(23);
            list1.Add(42);
            list1.Add(3);
            list1.Add(65);

            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine($"Lista zawiera : {list1[i]}");
            }

            Console.WriteLine("\n\n==================\n\n");
            list1.Remove(3);

            foreach (var item in list1)
            {
                Console.WriteLine($"Lista zawiera : {item}");
            }


            Console.WriteLine("\n\n===== LinkedList =====\n\n");


            LinkedList<int> list2 = new LinkedList<int>();

            list2.AddFirst(45);
            list2.AddLast(23);
            var beforeIt = list2.Find(23);
            list2.AddBefore(beforeIt, 16);

            foreach (var item in list2)
            {
                Console.WriteLine($"Lista zawiera : {item}");
            }
            Console.WriteLine("\n\n=======Po usuniecie======\n\n");

            list2.RemoveLast();

            foreach (var item in list2)
            {
                Console.WriteLine($"Lista zawiera : {item}");
            }




            Console.WriteLine("\n\n===== ISet =====\n\n");

            ISet<int> set1 = new HashSet<int>();

            set1.Add(21);
            set1.Add(15);
            set1.Add(14);
            set1.Add(18);

            foreach (var item in set1)
            {
                Console.WriteLine($"Zawiera: {item}");
            }

            set1.Remove(14);

            Console.WriteLine("\n\n=======Po usuniecie======\n\n");
            foreach (var item in set1)
            {
                Console.WriteLine($"Zawiera: {item}");
            }

            Console.WriteLine("\n\n===== ISet Sorted =====\n\n");
            ISet<int> set2 = new SortedSet<int>();

            set2.Add(21);
            set2.Add(15);
            set2.Add(14);
            set2.Add(18);

            foreach (var item in set2)
            {
                Console.WriteLine($"Zawiera: {item}");
            }

            set2.Remove(18);

            Console.WriteLine("\n\n=======Po usuniecie======\n\n");
            foreach (var item in set2)
            {
                Console.WriteLine($"Zawiera: {item}");
            }



            Console.WriteLine("\n\n===== IDictionary 'Dictionary' =====\n\n");

            IDictionary<string, int> dictionary3 = new Dictionary<string, int>(); // sortuje po kluczach alfabetycznie
            dictionary3.Add("Kaya", 165);
            dictionary3.Add("Angelika", 181);
            dictionary3.Add("Krystian", 182);
            dictionary3.Add("Marcel", 160);

            Console.WriteLine("Slownik zawiera:");
            foreach (var item in dictionary3)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            dictionary3.Remove("Krystian");
            Console.WriteLine("\n\n==================\n\n");

            foreach (var item in dictionary3)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("\n\n===== IDictionary 'SortedList' =====\n\n");

            IDictionary<string, int> dictionary4 = new SortedList<string, int>(); // sortuje po kluczach alfabetycznie
            dictionary4.Add("Kaya", 165);
            dictionary4.Add("Angelika", 150);
            dictionary4.Add("Krystian", 190);
            dictionary4.Add("Marcel", 180);

            Console.WriteLine("Slownik zawiera:");
            foreach (var item in dictionary4)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            dictionary4.Remove("Marcel");
            Console.WriteLine("\n\n==================\n\n");

            foreach (var item in dictionary4)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }



            Console.WriteLine("\n\n===== IDictionary 'SortedDictionary'' =====\n\n");

            IDictionary<string, int> dictionary5 = new SortedDictionary<string, int>(); // sortuje po kluczach alfabetycznie
            dictionary5.Add("Kaya", 165);
            dictionary5.Add("Angelika", 150);
            dictionary5.Add("Krystian", 190);
            dictionary5.Add("Marcel", 180);

            Console.WriteLine("Slownik zawiera:");
            foreach (var item in dictionary5)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            dictionary4.Remove("Marcel");
            Console.WriteLine("\n\n==================\n\n");

            foreach (var item in dictionary5)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("\n\n===== Queue<int> =====\n\n");
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);

            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n====== PO SCIAGNIECIU ======n\n");

            queue1.Dequeue();

            foreach (var item in queue1)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\n\n===== Stack =====\n\n"); // LIFO -> Last In First Out
            Stack<int> stack1 = new Stack<int>();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);

            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n====== PO SCIAGNIECIU ======n\n");

            stack1.Pop();

            foreach (var item in stack1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n===== PriorityQueue =====\n\n");
            //PriorityQueue<int, int> queue2 = new PriorityQueue<int, int>(); od .NET 6+

            #endregion

            Console.WriteLine("\n\n------------------ ZADANIE 4 -------------------\n\n");

            #region Zadanie 4

            DynamicArray<int> test = new DynamicArray<int>();

            test.Add(2);
            test.Add(3);
            test.Add(10);

            test[1] = 100;

            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = 0; i < test.Count; i++)
            {
                //Console.WriteLine(test[i]);
            }
            #endregion
        }
    }
}
