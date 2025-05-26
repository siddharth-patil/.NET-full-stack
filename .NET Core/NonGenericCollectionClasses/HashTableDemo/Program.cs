using System.Collections;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add(4, "four");
            ht.Add(5, "five");

            //Console.WriteLine("Elements in Hash Table are: ");
            //foreach(DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Key + ": " + item.Value);
            //}

            Console.WriteLine("Keys present in Hash Table are: ");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Values present in Hash Table are: ");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Key and Value pair in Hash Table are: ");
            foreach (var key in ht.Keys)
            {
                Console.WriteLine($"{key} : {ht[key]}");
            }
        }
    }
}
