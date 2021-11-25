using rm.Trie;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Foo
    {
        //public static int BinarySearchStartsWith(List<string> words, string prefix, int min, int max)
        //{
         
        //        while (max >= min)
        //        {
        //            int mid = (min + max) / 2;
        //            int comp = String.Compare(words[mid].Substring(0, prefix.Length), prefix);
        //            if (comp < 0)
        //            {
        //                min = mid + 1;
        //            }
        //            else if (comp > 0)
        //            {
        //                max = mid - 1;
        //            }
        //            else
        //            {
        //                return mid;
        //            }
        //        }
        //        return -1;
            
        //}

        public static List<List<string>> SearchSuggestions(List<string> reviewsRepository, string userInput)
        {
            //DateTime start = DateTime.MinValue;
            //DateTime end = DateTime.MinValue;
            //ITrieMap<int> trie = new TrieMap<int>();
            var temp = new List<List<string>>();
            var filter = new List<string>();
            reviewsRepository.Sort();
            //start = DateTime.Now;
            for (int i = 2; i < (userInput.Length + 1); i++)
            {
                var filter1 = (userInput.Substring(0, i));
                var list = new List<string>();
                list = reviewsRepository.Where(x => x.Contains(filter1)).ToList();
                temp.Add(list);
            }
            return temp;
        }
        //end = DateTime.Now;
        //foreach(var item in filter)
        //{
        //    //var item = userInput.Substring(0, i);
        //    var item1 = reviewsRepository.BinarySearch(item);
        //    if (item1 > 1)
        //    {
        //        set.Add(reviewsRepository[item1]);
        //    }
        //}
        //List<string> geek = new List<string>(reviewsRepository);
        //reviewsRepository.Sort();
        //ITrie trie = new Trie();
        //for (var i = 0; i < reviewsRepository.Count() - 1; i++)
        //{
        //    trie.Add(reviewsRepository[i],i);
        //}
        //foreach (var item in filter)
        //{
        //   var word = trie.ValueBy(item);
        //    var words = trie.KeysBy(word.ToString());
        //    //var wordss = trie.KeyValuePairs(item,);
        //    //if (words != false)
        //    // {
        //    //     set.Add(item);
        //    //     temp.Add(set);
        //    // }
        //}
        ////temp.Add(set);
        //return temp;
        //List<string> templist = new List<string>(reviewsRepository);

        //start = DateTime.Now;
        //foreach (var item in filter)
        //{
        //    var list = new List<string>();
        //    list = reviewsRepository.Where(x => x.(item)).ToList();
        //    //foreach (var ritem in reviewsRepository.Where(x=>x.IndexOf(item) == 0))
        //    //{  
        //    //}
        //    temp.Add(list);
        //    //int index = BinarySearchStartsWith(reviewsRepository, item, 0, reviewsRepository.Count - 1);
        //    //if (index == -1)
        //    //{
        //    //    //templist = new List<string>(reviewsRepository);
        //    //    // not found
        //    //}
        //    //    //templist.RemoveAt(index);

        //    //    // found
        //    //}
        //    //temp.Add(set);
        //}
        //end = DateTime.Now;
        //Console.WriteLine("{0}ms using Contains", end.Subtract(start).Milliseconds);
        //Console.WriteLine("{0}ms using Contains", end.Subtract(end).Milliseconds);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unisete broj rijeci koji zelite pretraziti: \n");
            int reviewsRepositoryCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Unesite rijeci za pretragu: \n");
            List<string> reviewsRepository = new List<string>();

            for (int i = 0; i < reviewsRepositoryCount; i++)
            {
                string reviewsRepositoryItem = Console.ReadLine();
                reviewsRepository.Add(reviewsRepositoryItem.ToLower());
            }
            Console.WriteLine("Unesite rijec po kojoj zelite pretragu: \n");
            string userInput = Console.ReadLine();

            List<List<string>> foo = Foo.SearchSuggestions(reviewsRepository, userInput.ToLower());

            Console.WriteLine(String.Join("\n", foo.Select(x => String.Join(" ", x))));

        }
    }

}

