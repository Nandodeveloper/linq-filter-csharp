using Practice.Filters;
using Practice.Models;

List<int> inteiros = [1, 1, 2, 3, 4, 5, 9, 9, 3, 4, 2, 8, 7, 5, 6, 12, 13, 16, 754, 700, 234, 123, 125];
Filter.LinqFilter(inteiros);
Filter.LinqFilterPairs(inteiros);

Book book1 = new Book("Pequeno Principe", 2003, "Fernando");
Book book2 = new Book("Harry Potter", 2001, "J.K. Rowling");
Book book3 = new Book("O Senhor dos Anéis", 2000, "J.R.R. Tolkien");
Book book4 = new Book("O Hobbit", 1999, "J.R.R. Tolkien");
Book book5 = new Book("A Guerra dos Tronos", 1996, "George R.R. Martin");

List<Book> books = new List<Book>();
books.Add(book1);
books.Add(book2);
books.Add(book3);
books.Add(book4);
books.Add(book5);

Filter.LinqFilterBook(books);

Product product = new Product("Caderno", 5.99);
Product product2 = new Product("Caneta", 1.99);
Product product3 = new Product("Lápis", 0.99);
Product product4 = new Product("Borracha", 0.50);

List<Product> products = new List<Product>();
products.Add(product);
products.Add(product2);
products.Add(product3);
products.Add(product4);

Filter.LinqFilterProduct(products);