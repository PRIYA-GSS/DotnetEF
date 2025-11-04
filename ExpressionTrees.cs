// //Dynamic Filter using Expression Trees
// using System;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Collections.Generic;
// using System.Data.Common;
// using System.Reflection.Metadata.Ecma335;


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
//         //Pric>30
//         var filtered = products.AsQueryable().Where(BuildFilter<Product>("Price", 30));
//         //AsQueryable is used to Link LINQ to Expressions.
//         foreach (var p in filtered)
//         {
//             Console.WriteLine($"{p.Name}-{p.Price}");
//         }
//     }
//     static Expression<Func<T, bool>> BuildFilter<T>(string propertyName, object value)
//     //takes any type and returns boolean
//     {
//         var param = Expression.Parameter(typeof(T), "x");
//         // creates a parameter x for lambda x=>
//         var property = Expression.Property(param, propertyName);
//         //accesses x.propertyName
//         var constant = Expression.Constant(value);
//         var comparision = Expression.GreaterThan(property, constant);//x.propertyName>value
//         return Expression.Lambda<Func<T, bool>>(comparision, param);
//         //combines everything into lambda function x=>x.Price>30

//     }
// }

