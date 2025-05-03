namespace Practice;

internal class Book
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Author { get; set; }
    public Book (string title, int year, string author)
    {
        Title = title;
        Year = year;
        Author = author;
    }
}
