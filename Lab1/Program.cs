using System;
using System.Collections.Generic;
using System.Diagnostics;
using DSA.DataStructures.Trees;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 10000;
            double average = 0;
            var bstKeyValueMap = new DictionaryKeyValueMap<int, int>();
                var intKeyValuePairs = new List<KeyValuePair<int, int>>();

                for (int i = 0; i < MAX; i++)
                {
                    intKeyValuePairs.Add(new KeyValuePair<int, int>(i, i + 42));
                }

            //var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();
            //intKeyValuePairs.Shuffle();

                CreateKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);

                //Console.WriteLine("DictionaryKeyValueMap");
                
                
            for (int c = 0; c < 10; c++)
            {

                //var dictionaryKeyValueMap = new DictionaryKeyValueMap<int, int>();


                //Console.WriteLine("DictionaryKeyValueMap");
                Console.WriteLine("BSTKeyValueMap");
                Console.WriteLine("Ordered");
                average += RemoveKeyValueMap<int, int>(bstKeyValueMap, intKeyValuePairs);


            }
            Console.WriteLine(average/10);

        }


        public static void CreateKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey,TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs )
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach( var kvp in keyValuePairs)
            {
                keyValueMap.Add(kvp.Key, kvp.Value);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(keyValueMap.Height);

        }


        public static double QueryKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Get(kvp.Key);
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(keyValueMap.Height);
            double extra = stopwatch.Elapsed.TotalSeconds;
            return extra;
        }

        public static double RemoveKeyValueMap<TKey, TValue>(
                IKeyValueMap<TKey, TValue> keyValueMap,
                List<KeyValuePair<TKey, TValue>> keyValuePairs)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var kvp in keyValuePairs)
            {
                keyValueMap.Remove(kvp.Key);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine(keyValueMap.Height);
            double extra = stopwatch.Elapsed.TotalSeconds;
            return extra;
        }
    }
}
