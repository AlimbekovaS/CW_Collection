using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            d.Add(1, 5);
            d.Add(2, 5);
            d.Add(3, 5);
            foreach (var item in d)
            {
                Console.WriteLine(item.Key+" - "+item.Value);

            }

            if(d.ContainsKey(2))
            {
                Console.WriteLine("-");
            }
            //ILookup<int, int> l = new Lookup<int, int>();


            return;
            Queue<int> qe = new Queue<int>();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
                qe.Enqueue(rnd.Next(1, 10));
                          
            Console.WriteLine("Очередь: ");
            foreach (int item in qe)        
                Console.WriteLine(item);

            Console.WriteLine("Очередь2: ");
            // foreach (int item in qe)
            int cc = qe.Count;
            for (int i = 0; i < cc; i++)
                Console.WriteLine(qe.Dequeue());

            Console.WriteLine("Count: "+qe.Count);









            return;
            ArrayList obj = new ArrayList()
            { 1,2,"string", 'c', 0.2f, true};
            WriteCollection(obj);
            return;

            ArrayList collection = Exampl01(5);
            Console.WriteLine("иСХОДНАЯ КОЛЛЕКЦИЯ ЧИСЕЛ:");
            WriteCollection(collection);

            RemoveElement(1, 5, ref collection);
            WriteCollection(collection);

            Console.WriteLine("sort");
            collection.Sort();
            WriteCollection(collection);

        }

        static ArrayList Exampl01(int i)
        {
            Random rnd = new Random();
            ArrayList arr = new ArrayList();
            for (int p = 0; p < i; p++)
            {
                arr.Add(p);
            }
            return arr;
        }
        public static void RemoveElement(int i, int j, ref ArrayList arr)
        {
            arr.RemoveRange(i, j);
        }
        public static void AddElement(int i, ref ArrayList arr)
        {
            arr.Add(i);
        }
        public static void WriteCollection(ArrayList arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine("{0}-\t{1}\t", item, item.GetType());

                if(item.GetType()==typeof(int))
                {
                    Console.WriteLine("*");
                }
            }
        }
        
    }
}
