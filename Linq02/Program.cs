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

            var groupedCategoryNames = Source.ProductList
              .GroupBy(p => p.Category);

            foreach (var group in groupedCategoryNames)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var productName in group.Select(p => p.ProductName))
                {
                    Console.WriteLine($"   - {productName}");
                }
            }
            //Helping By AI And I Understand It

            #endregion

        }
    }
}
