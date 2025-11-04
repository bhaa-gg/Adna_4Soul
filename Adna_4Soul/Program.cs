using Adna_4Soul.SortedLists;
using System;
using System.Collections;
using System.Collections.Generic;
namespace Adna_4Soul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //int[] arr = {1,2,3,9,5,4,2,5,6,7,8,1 };
            //Hashtable hashtable = new ();


            //foreach (int item in arr)
            //{
            //    if (hashtable.ContainsKey(item)) hashtable[item] = (int)hashtable[item] +1;
            //    else hashtable.Add(item, 1);
            //}

            //foreach (var item in hashtable )Console.WriteLine(item);

            #endregion

            #region Q2
            //        Hashtable hashtable = new() {
            //            {"A" , 10},
            //            {"B" , 25},
            //            {"C" , 17},
            //            {"D" , 125}
            //};
            //        string maxKey = null;
            //        int maxValue = int.MinValue;
            //        foreach (DictionaryEntry item in hashtable)
            //        {
            //            if ((int)item.Value > maxValue)
            //            {
            //                maxKey = (string)item.Key;
            //                maxValue = (int)item.Value;
            //            }
            //        }
            //        Console.WriteLine(maxKey);



            #endregion


            #region Q3
            //Hashtable hashtable = new() {
            //    { "key1", "apple" }, { "key2", "banana" }, { "key3", "apple" }
            //};

            //bool flag = false;


            //string ?  val  = Console.ReadLine() ?? "";

            //foreach (DictionaryEntry? item in hashtable)
            //{
            //    if( item?.Value.ToString() ==  val)
            //    {
            //        Console.WriteLine(item?.Key);
            //        flag=true;
            //    }
            //}
            //if(!flag)
            //    Console.WriteLine("Key not found");

            #endregion


            #region Q4
            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

            //Dictionary<string, List<string>> groups = new();


            //foreach (string word in words)
            //{
            //    string key = new string(word.OrderBy(c => c).ToArray());

            //    if (!groups.ContainsKey(key)) groups.Add(key , new List<string>());
            //        groups[key].Add(word);

            //}
            //foreach (var group in groups.Values) Console.WriteLine($"[{string.Join(", ", group)}]");


            #endregion




            #region Q5
            //int[] arr = { 1, 2, 3, 4, 5, 5 };
            //HashSet<int> set = new();
            //foreach (int num in arr) set.Add(num);
            //Console.WriteLine(set.Count == arr.Length ? "No duplicates" : "Have duplicates");
            #endregion


            #region Q6
            // SortedDictionary<int, string> stundents = new() {
            //     { 2, "Ahmed" },
            //     { 1, "Bahaa" },
            //     { 3, "Alaa" }
            // } ;

            // stundents.TryAdd(4, "Asmaa");
            //if(stundents.ContainsKey(4)) stundents.Remove(4);
            // stundents.TryGetValue(4, out string ?name);
            // Console.WriteLine(name);


            // foreach ( KeyValuePair < int, string>  item in stundents)
            // {
            //     Console.WriteLine(item);
            // }


            #endregion



            #region Q7
            //SortedList<int ,string> employee = new( new SortDescInt() ) {

            //    {101, "Bahaa" },
            //    {103, "Alaa" },
            //    {102, "Ahenmd" },
            //};

            //Console.WriteLine( employee.TryGetValue(101, out string? ass));

            //Console.WriteLine(employee.GetValueAtIndex(1));

            //if(employee.ContainsKey(1))Console.WriteLine (employee.Remove(1));

            //foreach (KeyValuePair<int, string>  item in employee) Console.WriteLine(item);



            #endregion



            #region Q8

            //HashSet<int> defNums = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //HashSet<int> arrNum = new HashSet<int>() { 2, 5, 7, 8, 10 };
            //Console.WriteLine(string.Join("," , defNums.Except(arrNum)));

            #endregion




            #region Q9
            //List<int> ints = new List<int>() {1,2,3,4,5,2,3,4,51,6,7,8,9,1 };
            //Console.WriteLine(string.Join("," , ints));

            //HashSet<int> UNQUEVALS = new HashSet<int>(ints);
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine(string.Join(",", UNQUEVALS));

            #endregion



            #region Q10
            //Hashtable ht = new Hashtable();
            //ht.Add(1, "one");
            //ht.Add(2, "two");
            //ht.Add(3, "three");
            //ht.Add(4, "four");
            //Hashtable ht2 = new Hashtable();

            //foreach (DictionaryEntry item in ht) ht2.Add(item.Value, item.Key);
            //foreach (DictionaryEntry item in ht2) Console.WriteLine(item);

            #endregion



            #region Q11

            //HashSet<int> defNums = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //HashSet<int> arrNum = new HashSet<int>() { 2, 5, 7, 8, 10 };

            //Console.WriteLine(string.Join(" , " , defNums.Union(arrNum)));
            //Console.WriteLine(string.Join(" , ", defNums.Intersect(arrNum)));

            #endregion

            #region Q12

            //Dictionary<string  , int> keyValuePairs = new Dictionary<string, int>() {
            //{"apple",1},
            //{"animal",2},
            //{"airport",3}

            //};


            //Console.Write("Enter Your Char : ");
            //char chr = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //int times= 0;

            //foreach (KeyValuePair<string, int> item in keyValuePairs)if (item.Key.Contains(chr)) times++;

            //Console.WriteLine($"find {chr} => {times} ");


            #endregion



            #region Q13

            //SortedSet<int> Numbers = new SortedSet<int>() { 1, 3, 5, 7, 9, 10 };

            //Console.Write("Enter target : ");
            //int.TryParse(Console.ReadLine(), out int target);

            //SortedSet<int> grater = new SortedSet<int>();

            //foreach ( int item in Numbers) if (item > target) grater.Add(item);

            //Console.WriteLine(string.Join(" - ", grater));

            #endregion


            #region 14

        //    SortedList<int, int> numbers = new SortedList<int, int>()
        //{
        //    { 1, 5 },
        //    { 2, 10 },
        //    { 3, 9 },
        //    { 4, 8 },
        //    { 5, 13 }
        //};

        //    List<int> evenKeys = new List<int>();

        //    foreach (KeyValuePair<int, int> item in numbers) if (item.Value % 2 == 0) evenKeys.Add(item.Key);
        //    Console.WriteLine(string.Join("," , evenKeys));


            #endregion
        }
    }
}
