using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace IsUnique
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some string: ");
            var inputString = Console.ReadLine();
            var str = inputString ?? string.Empty;

            CheckWithHashTable(str);
            CheckWithNoAdditionalDataStructure(str);
        }

        private static void CheckWithNoAdditionalDataStructure(string str)
        {
            Console.WriteLine("Using only Array as data structure: ");
            str = str.Replace(" ", string.Empty);
            var asciiBytes = Encoding.ASCII.GetBytes(str);
            
            var distinctArray = asciiBytes.Distinct().ToArray();
            var reportToUser = asciiBytes.Length == distinctArray.Length
                ? "Your string hasn't got repeating characters."
                : "Your string has got repeating characters.";

            #region Also can be used 'for' loop

            //reportToUser = "Your string hasn't got repeating characters.";
            //for (var i = 0; i < asciiBytes.Length; i++)
            //{
            //    for (var j = i + 1; j < asciiBytes.Length; j++)
            //    {
            //        if (asciiBytes[i] == asciiBytes[j])
            //        {
            //            reportToUser = "Your string has got repeating characters.";
            //            break;
            //        }
            //    }
            //}

            #endregion

            Console.WriteLine(reportToUser);
            Console.ReadLine();
        }

        private static void CheckWithHashTable(string str)
        {
            Console.WriteLine("Using List and HashTable: ");
            var list = str.ToList();
            list.RemoveAll(l => l == ' ');

            try
            {
                var hashTable = new Hashtable();
                list.ForEach(c => hashTable.Add(c, c.GetHashCode()));
                Console.WriteLine("Your string hasn't got repeating characters.");
            }
            catch
            {
                Console.WriteLine("Your string has got repeating characters.");
            }

            Console.ReadLine();
        }
    }
}
