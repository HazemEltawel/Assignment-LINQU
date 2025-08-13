using Assignment_LINQU;
using System.Linq;

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

        String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        var shorterNames =
        from digit in Arr.Select((name, Index) => new {Name = name ,Value = Index})
        where digit.Name.Length < digit.Value
        select digit;

        foreach (var item in shorterNames)
        {
            Console.WriteLine(item);
        }
        #endregion


    }
}