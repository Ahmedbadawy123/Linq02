namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get top 3 most expensive products

            //var top3MostExpensiveProducts = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);

            //foreach (var item in top3MostExpensiveProducts)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region 2. show page 2 of products, with page size = 5

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

            var productsLessThan25 = Source.ProductList
                .OrderBy(p => p.UnitPrice)
                .TakeWhile(p => p.UnitPrice < 25);

            foreach (var item in productsLessThan25)
            {
                Console.WriteLine(item);
            }    

            #endregion
        }
    }
}
