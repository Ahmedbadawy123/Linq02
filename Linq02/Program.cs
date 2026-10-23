using System.Diagnostics.Metrics;
using System.Drawing;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get top 3 most expensive products.

            //var top3MostExpensiveProducts = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);

            //foreach (var item in top3MostExpensiveProducts)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. show page 2 of products, with page size = 5.

            //int pageSize = 5;
            //int pageNumber = 2;

            //var page2Products = Source.ProductList
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);
            //// Helping By AI

            //foreach (var item in page2Products)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var productsLessThan25 = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var item in productsLessThan25)
            //{
            //    Console.WriteLine(item);
            //}    

            #endregion

            #region 4. Check if ALL products in the "Seafood" category are in stock.

            //var allSeafoodInStock = Source.ProductList
            //                        .Where(p => p.Category == "Seafood")
            //                        .All(p => p.UnitsInStock > 0);

            //Console.WriteLine( $"All Seafood Products Are In Stock: {allSeafoodInStock}" );

            #endregion

            #region 5. Check if the ID list contains 9 -> int[] ids = { 3, 9, 13, 18 };

            //var ids = new int[] { 3, 9, 13, 18 };
            //bool contains9 = ids.Contains(9);

            //Console.WriteLine($"Does ids Contain 9? {contains9}");

            #endregion

            #region 6. Group all products by Category and print each group with its product count.

            //var groupedProducts = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //     { 
            //         Category = g.Key, Count = g.Count()
            //     });

            //foreach (var item in groupedProducts)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 7. Group products by Category and project only product names per group.

            //var groupedCategoryNames = Source.ProductList
            //  .GroupBy(p => p.Category);

            //foreach (var group in groupedCategoryNames)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var productName in group.Select(p => p.ProductName))
            //    {
            //        Console.WriteLine($"   - {productName}");
            //    }
            //}
            //Helping By AI And I Understand It

            #endregion

            #region 8. Find all categories that have MORE THAN 3 products

            //var categoriesWithMoreThan3Products = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);

            //foreach (var item in categoriesWithMoreThan3Products)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.

            //var customerGroups = from c in Source.CustomerList
            //                     group c by c.Country into g
            //                     select new
            //                     {
            //                         Country = g.Key,
            //                         Count = g.Count(),
            //                         TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //                     };

            //foreach (var item in customerGroups)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 10. Calculate the total number of units in stock across all products

            //var totalUnitsInStock = Source.ProductList.Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total Units in Stock: {totalUnitsInStock}");

            #endregion

            #region 11. Find the CHEAPEST and MOST EXPENSIVE product prices

            //var cheapestProductPrice = Source.ProductList.Min(p => p.UnitPrice);
            //var mostExpensiveProductPrice = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest Product Price: {cheapestProductPrice}");
            //Console.WriteLine($"Most Expensive Product Price: {mostExpensiveProductPrice}");

            #endregion

            #region 12. Get a distinct list of all product categories

            //var distinctCategories = Source.ProductList
            //                         .Select(p => p.Category)
            //                         .Distinct();

            //foreach (var item in distinctCategories)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 13. find product IDs that are in setA but NOT in setB int[] setA = { 1, 3, 5, 7, 9, 11, 13 }; int[] setB = { 3, 6, 9, 12, 15, 13 };

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var productIdsInSetANotInSetB = setA.Except(setB);

            //foreach (var item in productIdsInSetANotInSetB)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 14. Find countries that appear in list1 but NOT in list2 (case -insensitive).string[] list1 = { "Germany", "France", "UK", "Spain" };string[] list2 = { "france", "SPAIN", "Italy" };

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var countriesInList1NotInList2 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in countriesInList1NotInList2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.

            //var productDictionary = Source.ProductList.ToDictionary(p => p.ProductID);

            //if (productDictionary.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine(product);
            //}

            // Helping By AI And I Understand It


            #endregion

            #region 16. Get the first product whose price is greater than $50.

            //var firstProductOver50 = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 50);

            //Console.WriteLine($"First product > $50: {firstProductOver50.ProductName}, Price: {firstProductOver50.UnitPrice:C2}");

            #endregion

            #region 17. Try to get the first product with a price > $500. it returns null instead of throwing.

            //var firstProductOver500 = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);
          
            //if (firstProductOver500 != null)
            //{
            //    Console.WriteLine($"First product > $500: {firstProductOver500.ProductName}, Price: {firstProductOver500.UnitPrice:C2}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found with price > $500.");
            //}


            #endregion

        }
    }
}
