// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using ElGuerre.Benchmarking;
using ElGuerre.Benchmarking.Lists;
using ElGuerre.Benchmarking.Memoized;
using static System.Console;

//JsonBuilder jsonBuilder = new JsonBuilder();
//jsonBuilder.Run();


//var languages = new[] { Language.English, Language.French, Language.Dutch };

//var output = languages.Select(l => Enum.GetName(l)).OrderBy(l => l);

//foreach (var l in output)
//{
//    Console.WriteLine(l);
//}

//var list = new ListBenchmark();
//list.Run();

//var dict1 = new Dictionary<long, Dictionary<long, decimal>>
//{
//    { 1, new Dictionary<long, decimal> { { 10, 1.23m }, { 20, 4.56m } } },
//    { 2, new Dictionary<long, decimal> { { 30, 7.89m }, { 40, 0.12m } } }
//};
//var dict2 = new Dictionary<long, Dictionary<long, decimal>>
//{
//    { 1, new Dictionary<long, decimal> { { 10, 1.23m }, { 20, 4.56m } } },
//    { 2, new Dictionary<long, decimal> { { 30, 7.89m }, { 40, 0.12m } } }
//};

//bool equals = dict1.CompareDictionaries(dict2);

//try
//{
//    if (equals)
//    {
//        Console.WriteLine("Todos los valores en los dos diccionarios son iguales.");
//    }
//    else
//    {
//        Console.WriteLine("Hay valores diferentes en los dos diccionarios.");
//    }
//}
//catch (Exception ex)
//{
//    WriteLine(ex.Message);
//}

// Memoized benchmark
var memoized = new MemoizedBenchmark();
memoized.Run();
// Conclusion: Not work !


//WriteLine("Press ENTER to finish...");
//ReadLine();
