using Assignment_LINQU;
using System.Linq;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        #region Find all products that are out of stock.
        //var outstock = from p in ListGenerators.ProductList
        //               where p.UnitsInStock == 0
        //               select p;
        //foreach (var item in outstock)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Find all products that are in stock and cost more than 3.00 per unit.

        //var outstock= from p in ListGenerators.ProductList
        //              where p.UnitsInStock>0&&p.UnitPrice > 3.00m
        //              select p;

        //foreach (var item in outstock)
        // {
        //     Console.WriteLine(item);
        // }
        #endregion

        #region  Returns digits whose name is shorter than their ==> value. String [] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var shorterNames =
        //from digit in Arr.Select((name, Index) => new {Name = name ,Value = Index})
        //where digit.Name.Length < digit.Value
        //select digit;

        //foreach (var item in shorterNames)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Get first Product out of Stock 

        //var firstProduct = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0).First();

        //Console.WriteLine(firstProduct);

        #endregion

        #region Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

        //var firstproduct = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
        //Console.WriteLine(firstproduct);

        #endregion

        #region Retrieve the second number greater than 5 

        //int[] numbers= { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; 

        //var secondNumber=numbers.Where(n=> n > 5).Skip(1).FirstOrDefault();
        //Console.WriteLine(secondNumber);


        #endregion

        #region Uses Count to get the number of odd numbers in the array

        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var oodCount=(from n in Arr
        //              where n % 2 != 0
        //              select n).Count();

        //Console.WriteLine(oodCount);

        #endregion

        #region Return a list of customers and how many orders each has.

        //var customersorders = ListGenerators.CustomerList.Select(c => new
        //{
        //    Customer = c.CustomerName,
        //    Order = c.Orders.Count()

        //});
        //foreach (var item in customersorders)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Return a list of categories and how many products each has

        //var categoriesproducts= ListGenerators.ProductList.GroupBy(p=>p.Category).Select(c => new
        //{
        //    Category = c.Key,
        //    Count = c.Count()
        //});

        //foreach (var item in categoriesproducts)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Get the total of the numbers in an array.

        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var total = Arr.Sum();
        //Console.WriteLine($"Total => {total}");

        #endregion

        #region Get the total number of characters of all words in dictionary_english.txt

        //string[] words = File.ReadAllLines("dictionary_english.txt");
        //int totalchar = words.Sum(word => word.Length);
        //Console.WriteLine($"Total characters in  {totalchar}");
        #endregion

        #region Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

        //string[]Words= File.ReadAllLines("dictionary_english.txt");
        //var shortword=Words.Min(word=> word.Length);
        //Console.WriteLine($"Length of the shortest word: {shortword}");


        #endregion

        #region Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

        //string[]Words= File.ReadAllLines("dictionary_english.txt");
        //var shortword=Words.Max(word=> word.Length);
        //Console.WriteLine($"Length of the shortest word: {shortword}");


        #endregion

        #region Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
        //string[]Words= File.ReadAllLines("dictionary_english.txt");
        //var shortword=Words.Average(word=> word.Length);
        //Console.WriteLine($"Length of the shortest word: {shortword}");
        #endregion

        #region Get the total units in stock for each product category.

        var total = from p in ListGenerators.ProductList
                    group p by p.Category into g
                    select new
                    {
                        Category = g.Key,
                        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
                    };
        foreach (var item in total)
        {
            Console.WriteLine(i);
        }

        #endregion


















    }
}