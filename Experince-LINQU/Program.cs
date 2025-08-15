using Assignment_LINQU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
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

        //var total = from p in ListGenerators.ProductList
        //            group p by p.Category into g
        //            select new
        //            {
        //                Category = g.Key,
        //                TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
        //            };
        //foreach (var item in total)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Get the cheapest price among each category's products
        //var cheapestprice = from p in ListGenerators.ProductList
        //                    group p by p.Category into g
        //                    select new
        //                    {
        //                        Category = g.Key,
        //                        cheapestprice = g.Min( p => p.UnitPrice)
        //                    };
        //foreach (var item in cheapestprice)
        //{
        //    Console.WriteLine(item);
        //}


        #endregion

        #region Get the products with the cheapest price in each category (Use Let)
        //var cheapestprice = from p in ListGenerators.ProductList
        //                    group p by p.Category into g
        //                    let cheape = g.Min(p => p.UnitPrice)
        //                    from p2 in g
        //                    where p2.UnitPrice == cheape
        //                    select new
        //                    {
        //                        Category = g.Key,
        //                        CheapestPrice = cheape,
        //                        price=p2.UnitPrice
        //                    };


        //foreach (var item in cheapestprice)
        //{
        //    Console.WriteLine(item);
        //}


        #endregion

        #region Get the most expensive price among each category's products.
        //var cheapestprice = from p in ListGenerators.ProductList
        //                    group p by p.Category into g
        //                    select new
        //                    {
        //                        Category = g.Key,
        //                        cheapestprice = g.Max(p => p.UnitPrice)
        //                    };
        //foreach (var item in cheapestprice)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Get the products with the most expensive price in each category.

        //var mostexpensive = from p in ListGenerators.ProductList
        //                    group p by p.Category into g
        //                    let maxprice = g.Max(p => p.UnitPrice)
        //                    from p2 in g
        //                    where p2.UnitPrice == maxprice
        //                    select new
        //                    {
        //                        category = g.Key,
        //                        prodactName = p2.ProductName,
        //                        price = p2.UnitPrice

        //                    };
        //foreach (var item in mostexpensive)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region  Get the average price of each category's products.
        //var cheapestprice = from p in ListGenerators.ProductList
        //                    group p by p.Category into g
        //                    select new
        //                    {
        //                        Category = g.Key,
        //                        cheapestprice = g.Average(p => p.UnitPrice)
        //                    };
        //foreach (var item in cheapestprice)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Find the unique Category names from Product List

        //var unique = ListGenerators.ProductList.Select(p => p.Category).Distinct();
        //foreach (var item in unique)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Produce a Sequence containing the unique first letter from both product and customer names.

        //var uniquelatter = ListGenerators.ProductList.Select(p => p.ProductName[0])
        //                                             .Concat(ListGenerators.CustomerList.Select(c => c.CustomerName[0])
        //                                             ).Distinct();
        //foreach (var item in uniquelatter)
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Produce a Sequence containing the unique first letter from both product and customer names.

        //var commonFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0])
        //                                                   .Intersect(ListGenerators.ProductList.Select(c => c.ProductName[0]));
        //foreach (var item in commonFirstLetters)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Create one sequence that contains the first letters of product names that are not also first letters of customer names.
        //var commonFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName[0])
        //                                                   .Except(ListGenerators.ProductList.Select(c => c.ProductName[0]));
        //foreach (var item in commonFirstLetters)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region  Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
        //var commonFirstLetters = ListGenerators.ProductList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
        //    .Concat(ListGenerators.CustomerList.Select(c => c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3))));
        //foreach (var item in commonFirstLetters)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Get the first 3 orders from customers in Washington

        //var order =
        //    (from c in ListGenerators.CustomerList
        //     where c.Region == "WA"
        //     from o in c.Orders
        //     select o).Take(3);
        //Console.WriteLine("First 3 orders from customers in Washington: ");
        //foreach (var item in order)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Get all but the first 2 orders from customers in Washington.

        // var order =
        //    (from c in ListGenerators.CustomerList
        //     where c.Region == "WA"
        //     from o in c.Orders
        //     select o).Skip(2);
        //Console.WriteLine("First 3 orders from customers in Washington: ");
        //foreach (var item in order)
        //{
        //    Console.WriteLine(item);
        //}
        #endregion

        #region Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
        //  int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var res = numbers.TakeWhile((num, Index) => num >= Index);

        //foreach (var item in res)
        //{
        //    Console.WriteLine($"Elements until a number is hit that is less than its position: {item}");
        //}

        #endregion

        #region Get the elements of the array starting from the first element divisible by 3.
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var res = numbers.SkipWhile(n=>n %3 != 0 );

        // foreach (var item in res)
        // {
        //     Console.WriteLine($"Elements starting from the first element divisible by 3: {item}");
        // }

        #endregion

        #region Get the elements of the array starting from the first element less than its position.

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        // var res = numbers.SkipWhile((n, index) => n >= index);
        //Console.WriteLine("Elements starting from the first element less than its position: ");
        // foreach (var item in res)
        // {
        //     Console.WriteLine(item);
        // }

        #endregion

        #region Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
        //string[] words = File.ReadAllLines("dictionary_english.txt");
        //bool contain = words.Any(word=>word.Contains("ei"));
        //Console.WriteLine($"Any word contains 'ei': {contain}");
        #endregion

        #region  Return a grouped a list of products only for categories that have at least one product that is out of stock.

        //var ground = from p in ListGenerators.ProductList
        //             where p.UnitsInStock == 0
        //             group p by p.Category into g
        //             select new
        //             {
        //                 category = g.Key,
        //                 Products = g.ToList()
        //             };
        //foreach (var item in ground)
        //    {
        //    Console.WriteLine($"Category: {item.category}");
        //    foreach (var product in item.Products)
        //    {
        //        Console.WriteLine($"  Product: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
        //    }
        //}
        #endregion

        #region   Return a grouped a list of products only for categories that have all of their products in stock.

        //var grouped = ListGenerators.ProductList
        //     .GroupBy(p => p.Category)
        //     .Where(g => g.All(p => p.UnitsInStock > 0))
        //     .Select(g => new
        //     {
        //         Category = g.Key,
        //         Products = g.ToList()
        //     });
        //foreach (var category in grouped)
        //{
        //    Console.WriteLine($"Category: {category.Category}");
        //    foreach (var product in category.Products)
        //    {
        //        Console.WriteLine($"   {product.ProductName} - Units in Stock: {product.UnitsInStock}");
        //    }
        //}
        #endregion

        #region Use group by to partition a list of numbers by their remainder when divided by 5

        //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //var partition = numbers.GroupBy(n => n % 5 );

        //foreach (var item in partition)
        //{
        //    Console.WriteLine($"Remainder {item.Key}: {string.Join(", ", item)}");
        //    Console.WriteLine();
        //}
        #endregion

        #region Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

        //string[] words= File.ReadAllLines("dictionary_english.txt");

        //var partition = words.GroupBy(word => word[0].ToString().ToUpper());

        //foreach (var item in partition)
        //{
        //    Console.WriteLine($"First Letter {item.Key}: {string.Join(", ", item)}");
        //}

        #endregion

        #region Consider this Array as an Input

        string[] Arr = { "from", "salt", "earn", " last", "near", "form" };

        var anagrams = Arr.GroupBy(word => string.Concat(word.OrderBy(c => c)));

        foreach (var group in anagrams)
        {
            Console.WriteLine($"Anagram Group: {group.Key}");
            foreach (var word in group)
            {
                Console.WriteLine($"  {word}");
            }
        }


        #endregion



























    }
}













