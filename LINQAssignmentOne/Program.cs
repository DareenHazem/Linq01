using LINQAssignmentOne.DataSources;

namespace LINQAssignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //var SeaFoodProducts = Source.ProductList.Where(p => p.Category == "Seafood");

            //foreach (var p in SeaFoodProducts)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Question 02
            //var ProductNames = Source.ProductList
            //                         .Select(p => p.ProductName).ToList();

            //foreach (var p in ProductNames)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Question 03
            //var Products = Source.ProductList.Where(p => (10 <= p.UnitPrice && p.UnitPrice <= 30));

            //foreach (var p in Products)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion
        }
    }
}
