using System.Reflection.Metadata.Ecma335;
using static LINQProj01.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;




namespace LINQProj01
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Restriction Operators

            #region 1. Find all products that are out of stock.
            //Differd Execution

            //var outOfStockProduct = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (Product product in outOfStockProduct) Console.WriteLine(product);

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var products = ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3);

            //foreach (Product product in products) Console.WriteLine(product);

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //var digits = ProductList.Where(p => p.ProductName.Length > p.UnitPrice).Select((p, i) => i);

            //foreach (int num in digits) Console.WriteLine(num);


            #endregion


            //Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //var productsNames = ProductList.Select(e => e.ProductName);
            //foreach (var productName in productsNames) Console.WriteLine(productName);

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //var result = ProductList.Select(p => new
            //{
            //    UpperCase = p.ProductName.ToUpper(),
            //    LowerCase = p.ProductName.ToLower(),
            //});

            //foreach (var item in result) Console.WriteLine($"UpperCase:{item.UpperCase},LowerCase:{item.LowerCase}");

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProductList.Select(p => new
            //{
            //    p.ProductID,
            //    p.ProductName,
            //    Price = p.UnitPrice
            //});

            //foreach (var item in result) Console.WriteLine($"ProductID:{item.ProductID},ProdutName:{item.ProductName},Price:{item.Price}");

            #endregion

            #region 4. Determine if the value of ints in an array match their position in the array.

            //int[] Arr = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];

            //var inPlace = Arr.Select((n,i)=> { if(n!=i) return false; return true; });

            //foreach ( bool i in inPlace) 
            //Console.WriteLine(i);


            #endregion


            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.


            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };


            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b };

            //foreach ( var item in result ) Console.WriteLine($"{item.A} is smaller than {item.B}");


            #endregion

            #region 6. Select all orders where the order total is less than 500.00.


            //var result = CustomerList.SelectMany(c => c.Orders);

            //foreach (var item in result) Console.WriteLine(item);




            #endregion


            #region 7. Select all orders where the order was made in 1998 or later.
            //var result = CustomerList.SelectMany(c => c.Orders).Where(o=>o.OrderDate.Year == 1998);
            //foreach (var item in result) Console.WriteLine(item);

            #endregion
        }
    }
}
