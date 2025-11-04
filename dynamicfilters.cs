
// using System;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Collections.Generic;
// using System.Diagnostics;

// public class Product

// {
//     public string Name { get; set; }
//     public int Price { get; set; }
// }

// class Program
// {
//     static void Main()
//     {
//         var products = new List<Product>
//         {
//             new Product { Name = "Pen", Price = 10 },
//             new Product { Name = "Notebook", Price = 50 },
//             new Product { Name = "Bag", Price = 100 }
//         };

//         // Build individual filters
//         var filter1 = BuildFlexibleFilter<Product>("Price", 30);
//         var filter2 = BuildFlexibleFilter<Product>("Name", "Notebook");

//         // Combine filters: Price > 30 && Name == "Notebook"
//         var combinedFilter = CombineFilters(filter1, filter2);

//         var result = products.AsQueryable().Where(combinedFilter);

//         // Output
//         foreach (var p in result)
//         {
//             Console.WriteLine($"{p.Name} - {p.Price}");
//         }
//     }
//     static Expression<Func<T, bool>> BuildFlexibleFilter<T>(string propertyName, object value)
//     {
//         var param = Expression.Parameter(typeof(T), "x");
//         var property = Expression.Property(param, propertyName);
//         var constant = Expression.Constant(value);
//         Expression comparison;

//         if (property.Type == typeof(string))
//         {
//             comparison = Expression.Equal(property, constant);
//         }
//         else if (property.Type == typeof(int))
//         {
//             comparison = Expression.GreaterThan(property, constant);
//         }
//         else
//         {
//             throw new NotSupportedException("Type not supported");
//         }
//         return Expression.Lambda<Func<T, bool>>(comparison, param);

//     }
//     static Expression<Func<T,bool>> CombineFilters<T>(Expression<Func<T,bool>> expr1, Expression<Func<T,bool>> expr2)
//     {
//         var param = Expression.Parameter(typeof(T), "x");
//         var body = Expression.AndAlso(
//             Expression.Invoke(expr1, param),
//             Expression.Invoke(expr2, param)

//         );
//         return Expression.Lambda<Func<T, bool>>(body, param);
//     }
// }
