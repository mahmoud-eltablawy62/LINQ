# LINQ in C#

LINQ (Language-Integrated Query) is a powerful feature in C# that provides a unified syntax and set of operators to query and manipulate data from various data sources. It was introduced in C# 3.0 and has become an essential tool for working with collections, databases, XML, and other data formats.

## Key Concepts in LINQ

- **Data Sources**: LINQ supports querying data from various sources, including in-memory collections, databases, XML documents, and more.

- **Query Expressions**: LINQ introduces a query expression syntax that allows you to write queries in a declarative manner.

- **Standard Query Operators**: LINQ provides a rich set of standard query operators that can be used with any data source that implements the `IEnumerable<T>` or `IQueryable<T>` interfaces.

- **Deferred Execution**: LINQ queries are lazily evaluated by default, which means that the actual execution of the query is deferred until the query results are actually needed.

- **Strongly Typed**: LINQ is strongly typed, meaning that it provides compile-time type checking and IntelliSense support.

- **Extension Methods**: LINQ extends the capabilities of collections by introducing extension methods.

## Example of LINQ Query

```csharp
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = from num in numbers
                  where num % 2 == 0
                  select num;

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
