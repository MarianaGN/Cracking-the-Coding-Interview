using System;
using System.Linq;

namespace CheckPermutation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first string: ");
            var firstStr = Console.ReadLine();
            firstStr = firstStr ?? string.Empty;

            Console.WriteLine("Enter second string: ");
            var secondStr = Console.ReadLine();
            secondStr = secondStr ?? string.Empty;

            var orderedFirstStr = firstStr.ToList().OrderBy(c => c).ToList();
            var orderedSecondStr = secondStr.ToList().OrderBy(c => c).ToList();

            var isSameLength = orderedFirstStr.Count == orderedSecondStr.Count;
            var isEqual = isSameLength;

            if (isSameLength)
            {
                var i = 0;
                while (isEqual && i < orderedFirstStr.Count)
                {
                    isEqual = orderedFirstStr[i] == orderedSecondStr[i];
                    i++;
                }
            }

            var reportToUser = isEqual
                ? "Two strings are permutation of the same string."
                : "Two strings are not permutation of the same string.";

            Console.WriteLine(reportToUser);
            Console.ReadLine();
        }
    }
}
