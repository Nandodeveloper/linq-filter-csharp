using System.Linq;
using Practice.Models;

namespace Practice.Filters;

internal class Filter
{
    public static void LinqFilter(List<int> inteiros)
    {
        var inteiro = inteiros.Distinct().Order().ToArray();
        foreach (int i in inteiro)
        {
            Console.WriteLine(i);
        }
    }
    public static void LinqFilterPairs(List<int> ints)
    {
        var inteiros = ints.Distinct().Where(ints => ints % 2 == 0).Order().ToArray();
        foreach (int i in inteiros)
        {
            Console.WriteLine(i);
        }
    }
    public static void LinqFilterBook(List<Book> books)
    {
        var booksPerYear = books.Where(books => books.Year >= 2000).OrderBy(books => books.Title).Distinct().ToArray();
        foreach (var book in booksPerYear)
        {
            Console.WriteLine(book.Title);
        }
    }
    public static void LinqFilterProduct(List<Product> products)
    {
        var productsPrice = products.Distinct().Select(products => products.Price).Average().ToString();
        Console.WriteLine(productsPrice);
    }
}
