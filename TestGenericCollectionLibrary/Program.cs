using GenericCollectionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericCollectionLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenericCollections.About);

            var stringDictionary = new StringDictionary();
            stringDictionary.Add(7, "Irena");
            stringDictionary.Add(4, "Sammy");
            stringDictionary.Add(25, "Ben");
            stringDictionary.Add(42, "Seth");
            stringDictionary.Add(97, "Ken");
            stringDictionary.Add(55,"Kellan");
            stringDictionary.Add(3, "Chris");

            Console.WriteLine($"The person with the fav nbr of 42 is {stringDictionary.Get (42)}.");
            foreach(var data in stringDictionary.values())
            {
                Console.WriteLine(data);
            }

            var strings = new StringList();
            strings.Add("AAA");
            strings.Add("BBB");
            strings.Add("CCC");
            strings.Add("ddd", "eee");
            strings.Add("fff", "ggg", "hhh");
            strings.Add("iii", "jjj", "kkk", "lll");            
            foreach(var str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
