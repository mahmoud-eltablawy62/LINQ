using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using static ListGenerator;


#region What The LinQ
//List <int> Numbers = new List<int>() {25 , 30 , 50 , 80 , 150 , 250 , 525 , 413};
//var even = Numbers.Where( (n) => n % 2 == 0).ToList();
//foreach (int n in even)
//    Console.WriteLine(n);   
#endregion

#region LinQSyntax 
/////////////////////////// lInQ ////////////////////// 


//List<int> Numbers = new List<int>() { 25, 27, 28, 35 };
// ///1 ==> ///// fluentSynatax
////////// StaticMethods ///////////////////
//var numbers = Enumerable.Where<int>(Numbers, (n) => n % 2 > 0);
//////////////// ExtensionsMethods /////////////////////
//var numbers2 = Numbers.Where((n) => n % 2 == 0);
//// 2=> ///// QuerySyntax ////////////////// 
//var number3  = from N in Numbers
//               where N % 2 == 0 
//               select N;

//foreach (var number in numbers) 
//    Console.WriteLine("StaticMethods == > " + number);


//foreach (var number in numbers2)
//    Console.WriteLine("ExtensionsMethods == > " + number);

//foreach (var number in number3)
//    Console.WriteLine("QuerySyntax == > " + number);
#endregion



//////////////////// Immediate ///////////////// 

#region Element_Operator 
/////////////////// first / last //////////////

//var result = ProductsList.First();
//result = ProductsList.Last(); 

/////////////////// first Defualt / last defualt //////////////

//ProductsList = new List<Product>();
//var result = ProductsList.FirstOrDefault();
//result = ProductsList.LastOrDefault();
//Console.WriteLine(result?.ProductName ?? "Data Is Empty");  

//////////////////// anthor overload for (firs/last)OrDefualt ///////////// 

//ProductsList = new List<Product>();
//var Result = ProductsList.FirstOrDefault(new Product () { ProductName = "MahmoudEltablawy" }); 
//Console.WriteLine(Result.ProductName);  

////////////////////Anthor Overload For First/Last///////////// 

//var result = ProductsList.First(p => p.UnitPrice > 100);
//result = ProductsList.Last(p => p.UnitPrice > 100);
//Console.WriteLine(result);

//////////////////// Anthor Overload For (firs/last)OrDefualt  ///////////////

//var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
//Console.WriteLine(result?.ProductName?? "Na");

//////////////////// Anthor Overload For (firs/last)OrDefualt  ///////////////

//var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000 , new Product () { ProductName = "Mahmoud Eltablawy"} );
//Console.WriteLine(result?.ProductName ?? "Na");

/////////////////////// ElementAt / ElementAtOrDefualt ///////////////////
//var result = ProductsList.ElementAt(25);
//result = ProductsList.ElementAtOrDefault(100);
//Console.WriteLine(result?.ProductName ?? "Not Found");

////////  Single / SingleOrDefualt ///////////////////// 
//ProductsList = new List<Product>();

//var result = ProductsList.Single();
//Console.WriteLine(result); ///// ======> Exception

//var result2 = ProductsList.SingleOrDefault( new Product() { ProductName = "Salah"} );
//Console.WriteLine(result2.ProductName);

//var result = ProductsList.SingleOrDefault(p => p.UnitPrice > 1000, new Product() { ProductName = "Mahmoud Eltablawy" });
//Console.WriteLine(result.ProductName);

//var result3 = ProductsList.Single(p => p.ProductID == 22);
//Console.WriteLine(result3.ProductName);
#endregion


#region Aggregate_Operator 

//var result = ProductsList.Count();
//Console.WriteLine(result);

//result = ProductsList.Count(p => p.UnitsInStock == 0);
//Console.WriteLine(result);

//var result2 = ProductsList.Max();
///// from Icomparable 
//Console.WriteLine(result2.ProductName);
//var result3 = ProductsList.OrderByDescending(p => p.UnitPrice).First();
//Console.WriteLine(result3.ProductName);
//result3 = ProductsList.MaxBy(p => p.UnitPrice);
//Console.WriteLine(result3.ProductName);


//var result = ProductsList.Max(new unitofstock());
//Console.WriteLine(result);

//var result  = ProductsList.Sum( p => p.UnitPrice );
//Console.WriteLine(result);

//result = ProductsList.Average( p => p.UnitPrice );
//Console.WriteLine(result);

//string mess = "hello";
//string[] Name = ["mahmoud", "saied", "eltablawy"];
//string result = Name.Aggregate( mess,(str1, str2) => str1 + " " + str2);
//Console.WriteLine(result);

#endregion


#region Casting_Operator 

//List <Product> products = ProductsList.Where(p => p.UnitsInStock == 0).ToList();
//Product [] arr = ProductsList.Where(P => P.UnitsInStock == 0).ToArray();
//Dictionary<long, string> Products = ProductsList.Where(P => P.UnitsInStock == 0)
//                                                  .ToDictionary(p => p.ProductID , p => p.ProductName);
//HashSet<Product> sets = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet(); 

//foreach (var x in Products) 
//    Console.WriteLine(x);
#endregion

////////////////////////// differd operator ////////////////// 



#region Filteration 
//var result = ProductsList.Where((x) => x.UnitsInStock > 0 && x.Category == "Meat/Poultry");    
//var result2 = from n in ProductsList
//              where n.UnitsInStock > 0 &&  n.Category == "Meat/Poultry"
//              select n;
//var result3 = ProductsList.Where((p, I) => I < 10 && p.UnitsInStock == 0);
//Console.WriteLine("unitstock > 0 && category == Meat/poiltry =========>  ");
//foreach (var product in result) Console.WriteLine(product);
//Console.WriteLine();
//Console.WriteLine("index to 10 and category == Meat/poiltry  =========>  ");
//foreach (var product in result3) Console.WriteLine(product);
#endregion


#region Transformation

//var product_name = ProductsList.Select((p) => p.ProductName);
//var product_name2 = from p in ProductsList
//                    select p.ProductName;

//var customers = CustomersList.SelectMany(c => c.Orders);
//var customers2 = from C in CustomersList 
//                from O in C.Orders 
//                select O;

//var ano_Type = ProductsList.Select(p => new { id = p.ProductID, name = p.ProductName });
//ano_Type = from p in ProductsList
//           select new
//           {
//               id = p.ProductID,
//               name = p.ProductName,
//           };

//var discount = ProductsList.Where(p => p.UnitsInStock > 0)
//    .Select(p => new
//    {
//        id = p.ProductID,
//        name = p.ProductName,
//        new_salary = p.UnitPrice - (p.UnitPrice * 0.1m)
//    });
//discount = from p in ProductsList
//           where p.UnitsInStock > 0
//           select new
//           {
//               id = p.ProductID,
//               name = p.ProductName,
//               new_salary = p.UnitPrice - (p.UnitPrice * 0.1m)
//           };

//var index = ProductsList.Where(p => p.UnitsInStock < 0)
//                        .Select((P,I) => new { 
//                            id = I,
//                            name = P.ProductName,
//                        });

//foreach(var Product in product_name2) 
//    Console.WriteLine(Product);


//foreach (var customer in customers2)
//    Console.WriteLine(customer);

//foreach (var p in ano_Type)
//    Console.WriteLine(p);


//foreach (var p in discount)
//    Console.WriteLine(p);

//foreach (var p in index)
//    Console.WriteLine(p);
#endregion


#region OrderingOperator

//var products = ProductsList.OrderBy(p => p.UnitsInStock).ThenByDescending(p => p.UnitPrice);
//products = from p in ProductsList 
//           orderby p.UnitsInStock ,   p.UnitPrice descending
//           select p;

//var products = ProductsList.Where(p => p.UnitsInStock == 0).Reverse();
//foreach (var product in products )  
//    Console.WriteLine(product);

#endregion


#region Generation Operator 

//var result = Enumerable.Range(0, 100);
//var result2 = Enumerable.Repeat(new Product() , 100);
//var result3 = Enumerable.Empty<Product>();
//foreach (var x in result3)
//    Console.Write($"{x} , ");
#endregion


#region SetOperator 

//var seq01 = Enumerable.Range(0, 100);
//var seq02 = Enumerable.Range(50, 190);

//var result1 = seq01.Union(seq02);    
//var result2 = seq01.Except(seq02);
//var result3 = seq02.Except(seq01);
// ////////////// anthor way for union  ////////////////////// 
//var result4 = seq01.Concat(seq02);
//result4 = result4.Distinct();

//foreach (var item in result3)   
//    Console.Write($"{item} ");

//var seq01 = new List<Product>() {
//                    new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
//                            UnitPrice = 18.00M, UnitsInStock = 100},
//                    new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
//                        UnitPrice = 19.0000M, UnitsInStock = 17 },
//                    new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
//                        UnitPrice = 10.0000M, UnitsInStock = 13 },
//                                };
//var seq02 = new List<Product>() {
//                    new Product() {ProductID = 1, ProductName = "Chai", Category = "Beverages",
//                            UnitPrice = 18.00M, UnitsInStock = 100},
//                    new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
//                        UnitPrice = 22.0000M, UnitsInStock = 53 },
//                    new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
//                        UnitPrice = 21.3500M, UnitsInStock = 0 },
//                                };

//var result = seq01.Union(seq02 , new MyEqualityComarer());


/////////////////// .Net 5 /////////////////////// 
//result = seq01.Intersect(seq02 , new MyEqualityComarer());
////////////////// .Net 6  //////////////////////
//var result2 = seq01.IntersectBy(seq02.Select(p => p.ProductID), x => x.ProductID);

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}    


#endregion


#region Quantifier Operators

//var seq01 = Enumerable.Range(0, 100);
//var seq02 = Enumerable.Range(0, 100);

//Console.WriteLine(
//   // ProductsList.Any()
//   // ProductsList.Any(P => P.UnitsInStock == 0)
//  // ProductsList.All(p => p.UnitPrice > 0)
//   seq01.SequenceEqual(seq02)   
//    ); 

#endregion


#region Ziping Operator

// List<string> Names = new List<string>() { "mahmoud" , "salah" , "nabil"};

//int[] numbers = [1, 2, 3];

//var result = Names.Zip(numbers , (name , number) => $"{number} ==> {name}");

//foreach(var x in result)
//    Console.WriteLine(x);

#endregion


#region Grouping Operator

//var category = from x in ProductsList
//               group x by x.Category;
//category = ProductsList.GroupBy(p => p.Category);
//foreach (var x in category)
//{
//    Console.WriteLine(x.Key);
//    foreach (var item in x)
//        Console.WriteLine($".........{item}");
//}
//var Category = from p in ProductsList
//               where p.UnitsInStock > 0 
//               group p by p.Category 
//               into cat
//               where cat.Count() > 10
//               select new { Categoryname = cat.Key  , CategoryCount = cat.Count()  };
//foreach (var x in Category)
//{
//        Console.WriteLine(x);
//}

//Category = ProductsList.Where(p => p.UnitsInStock > 0)
//    .GroupBy(p => p.Category)
//    .Where(cat => cat.Count() > 10)
//    .Select(cat => new
//    { Categoryname = cat.Key, CategoryCount = cat.Count() }
//    );
//foreach (var x in Category)
//{
//    Console.WriteLine(x);
//}

#endregion


#region Partioning Operator 

//var Result = ProductsList.Where(p => p.UnitsInStock > 0).Take(5);

//var Result = ProductsList.Where(p => p.UnitsInStock > 0).TakeLast(5);

// var Result = ProductsList.Where(P => P.UnitsInStock > 0).Skip(5);

//var Result = ProductsList.Where(P => P.UnitsInStock > 0).SkipLast(5);
//foreach (var result in Result)
//    Console.WriteLine(result);

//int[] numbers = {20, 50, 9, 12, 15};
//var Result = numbers.TakeWhile((number , index) => number > index);

//Result = numbers.SkipWhile(number => number % 3 != 0); 

//foreach (var item in Result)
//    Console.WriteLine(item);



#endregion

#region Let/Into 

//List<string> Names = new List<string>() {"mahmoud" , "Salah" , "Nabil" };

//var result = from N in Names
//             select Regex.Replace(N, "[aeouiAeouI]", string.Empty)
//             into NotVowelName
//             where NotVowelName.Length >= 3 
//             select NotVowelName;

// result = from N in Names
//            let NotVowelName = Regex.Replace(N, "[aeouiAeouI]", string.Empty)
//             where NotVowelName.Length >= 3
//             select NotVowelName;

//foreach (var item in result)
//    Console.WriteLine(item);




 
#endregion