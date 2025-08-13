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

        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        var oodCount=(from n in Arr
                      where n % 2 != 0
                      select n).Count();

        Console.WriteLine(oodCount);



        #endregion


















    }
}