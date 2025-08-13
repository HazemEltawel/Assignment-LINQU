using Assignment_LINQU;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        #region Find all products that are out of stock. 
        var outstock = from p in ListGenerators.ProductList
                       where p.UnitsInStock == 0
                       select p;
        foreach (var item in outstock)
        {
            Console.WriteLine(item);
        }
        #endregion

    }
}