using System.Collections;
using System.Text.RegularExpressions;
using static demo.ListGenerator;
namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting Operators
            //List<Product> productList =  ProductsList.Where(p=>p.UnitsInStock == 0).ToList().ToList();
            //Product[] productList = ProductsList.Where(p => p.UnitsInStock == 0).ToList().ToArray();
            //Dictionary<long , Product> productList = ProductsList.Where(p => p.UnitsInStock == 0).ToList().ToDictionary(p=>p.ProductID);
            //Dictionary<long, string> productList = ProductsList.Where(p => p.UnitsInStock == 0).ToDictionary(p=>p.ProductID , p=>p.ProductName);
            //HashSet<Product> productList = ProductsList.Where(p=>p.UnitsInStock == 0).ToHashSet();
            //ArrayList obj = new ArrayList()
            //{
            //    "Omar",
            //    "Ahmed",
            //    "Mona",
            //    "Aliaa",
            //    1,
            //    2,
            //    3,
            //};
            //var productList = obj.OfType<string>(); 
            //foreach (var unit in productList)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Generation Operators
            //var result = Enumerable.Range(1, 100);
            //var result = Enumerable.Repeat(1, 10);
            //var result = Enumerable.Empty<Product>();
            //Product[] result  = new Product[0];

            //foreach (var item in result)
            //{
            //    Console.Write($"{item}  ");
            //}
            #endregion
            #region Set Operators
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);
            ////var result = seq01.Union(seq02);
            ////var result = seq01.Concat(seq02);
            ////result = result.Distinct();
            ////var result = seq01.Intersect(seq02);
            //var result = seq01.Except(seq02);
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion
            #region Quantifier Operators - (Return Boolean)
            //var result = ProductsList.Any();
            //var result = ProductsList.Where(p=>p.UnitsInStock ==1200).Any();
            //var result = ProductsList.All(p => p.UnitsInStock >= 0);
            //var result = ProductsList.Any(p => p.UnitsInStock >= 0);
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(1, 100);
            //var result = seq01.SequenceEqual(seq02);
            //Console.WriteLine(result);

            #endregion
            #region Zipping Operator
            //string[] Names = { "Omar", "Amr", "Ahmed", "May", "Aya" };
            //int[] numbers = Enumerable.Range(1, 10).ToArray();
            //char[] Chars = { 'A', 'B', 'C', 'D', 'E' };

            //var result = Names.Zip(numbers);
            //var result = Names.Zip(numbers , (Names , numbers)=> new {index = numbers , Names});
            //var result = Names.Zip(numbers, Chars);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Grouping Operators
            //var result = ProductsList.GroupBy(p => p.Category);
            //var result = from P in ProductsList
            //             group P by P.Category;
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category);
            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category;
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Where(p => p.Count() > 10);
            //var result = from p in ProductsList
            //             where p.UnitsInStock > 0
            //             group p by p.Category
            //             into c
            //             where c.Count() > 10
            //             select c;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine($"               {item2.ProductName}");
            //    }
            //}
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).GroupBy(p => p.Category).Where(p => p.Count() > 10).Select(c => new
            //{
            //    categoryName = c.Key,
            //    count = c.Count()
            //});
            //    var result = from p in ProductsList
            //                 where p.UnitsInStock > 0
            //                 group p by p.Category
            //                 into g
            //                 where g.Count() > 10
            //                 select new
            //                 {
            //                     categoryName = g.Key , 
            //                     count = g.Count(),
            //                 };

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            #endregion
            #region Partitioning Operator
            //var result = ProductsList.Take(10);
            //var result = ProductsList.Where(p => p.UnitsInStock > 0).Take(5);
            //var result = ProductsList.Where(p=>p.UnitsInStock > 0).TakeLast(5);
            //var result = ProductsList.Skip(5);
            //var result = ProductsList.Where(p=>p.UnitsInStock == 0).Skip(2);
            //var result = ProductsList.SkipLast(5);
            //var result = ProductsList.Where(p=>p.UnitsInStock == 0).SkipLast(2);
            //int[] numbers = { 4, 5, 6, 9, 3, 2, 1, 7, 8 };
            ////var result = numbers.TakeWhile(n => n > 2);
            //var result = numbers.SkipWhile(n => n > 2);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Let And Into
            List<string> names = new List<string>() { "Omar" , "Ali" , "Sally" , "Mohamed" , "Ahmed"};
            //var result = from n in names
            //             select Regex.Replace(n, "[AOUIEaouie]", string.Empty)
            //             into novel
            //             where novel.Length > 3
            //             select novel;
            var result = from n in names
                         let novelName = Regex.Replace(n, "[AOUIEaouie]", string.Empty)
                         where novelName.Length > 3
                         select novelName;
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            
                         

            #endregion
        }

    }
}


