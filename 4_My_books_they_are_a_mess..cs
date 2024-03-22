
class task_4
{
    internal static IEnumerable<object> books;

    static void sick(string[] args)
    {
        List<Book> books = new List<Book>
        {
            new Book { Title = "Meditations: A New Translation", PublicationYear = 2002, Author = "Marcus Aurelius (Translated by Gregory Hays)", Isbn = "978-0812968255" },
            new Book { Title = "Snuff", PublicationYear = 2011, Author = "Terry Pratchett", Isbn = "0-385-61823-5" },
            new Book { Title = "The Collapsing Empire", PublicationYear = 2017, Author = "John Scalzi", Isbn = "978-0765388889" },
            new Book { Title = "The Colour of Magic", PublicationYear = 1983, Author = "Terry Pratchett", Isbn = "0-86140-324-X" },
            new Book { Title = "The Art of War: A New Translation", PublicationYear = 2018, Author = "Sun Tzu (Translated by Michael Nylan)", Isbn = "978-0393355524" },
            new Book { Title = "Thief of Time", PublicationYear = 2001, Author = "Terry Pratchett", Isbn = "0-385-60224-3" },
            new Book { Title = "Reaper Man", PublicationYear = 1991, Author = "Terry Pratchett", Isbn = "0-575-04979-4" },
            new Book { Title = "The Last Emperox", PublicationYear = 2020, Author = "John Scalzi", Isbn = "978-0765389176" },
            new Book { Title = "Hogfather", PublicationYear = 1996, Author = "Terry Pratchett", Isbn = "0-575-06403-X" },
            new Book { Title = "The Ocean at the End of the Lane", PublicationYear = 2013, Author = "Neil Gaiman", Isbn = "0-06-225565-7" }
        };

        // Return only books starting with "The"

        var booksStartingWithThe = books.Where(book => book.Title.StartsWith("The")).ToList();
        Console.WriteLine("Books starting with 'The':");
        PrintBooks(booksStartingWithThe);

        // Return only books written by authors with a 't' in their name
        var booksAuthorsWithT = books.Where(book => book.Author.ToLower().Contains("t")).ToList();
        Console.WriteLine("\nBooks written by authors with 't' in their name:");
        PrintBooks(booksAuthorsWithT);

        // The number of books written after 1992
        var booksAfter1992Count = books.Count(book => book.PublicationYear > 1992);
        Console.WriteLine($"\nThe number of books written after 1992: {booksAfter1992Count}");

        // The number of books written before 2004
        var booksBefore2004Count = books.Count(book => book.PublicationYear < 2004);
        Console.WriteLine($"The number of books written before 2004: {booksBefore2004Count}");

        // Return the isbn number of all the books for a given author
        string authorName = "Terry Pratchett"; // Example author name
        var isbnsForAuthor = books.Where(book => book.Author == authorName).Select(book => book.Isbn).ToList();
        Console.WriteLine($"\nISBN numbers for books by author '{authorName}':");
        foreach (var isbn in isbnsForAuthor)
        {
            Console.WriteLine(isbn);
        }

        // List books alphabetically ascending
        var booksAlphabeticallyAscending = books.OrderBy(book => book.Title).ToList();
        Console.WriteLine("\nBooks listed alphabetically (ascending):");
        PrintBooks(booksAlphabeticallyAscending);

        // List books chronologically ascending
        var booksChronologicallyAscending = books.OrderBy(book => book.PublicationYear).ToList();
        Console.WriteLine("\nBooks listed chronologically (ascending):");
        PrintBooks(booksChronologicallyAscending);

        // List books grouped by author last name
        var booksGroupedByAuthorLastName = books.GroupBy(book => book.Author.Split(' ').Last()).ToList();
        Console.WriteLine("\nBooks grouped by author last name:");
        foreach (var group in booksGroupedByAuthorLastName)
        {
            Console.WriteLine($"Author last name: {group.Key}");
            PrintBooks(group.ToList());
        }

        // List books grouped by author first name
        var booksGroupedByAuthorFirstName = books.GroupBy(book => book.Author.Split(' ').First()).ToList();
        Console.WriteLine("\nBooks grouped by author first name:");
        foreach (var group in booksGroupedByAuthorFirstName)
        {
            Console.WriteLine($"Author first name: {group.Key}");
            PrintBooks(group.ToList());
        }

    }

    static void PrintBooks(List<Book> books)
    {
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Publication Year: {book.PublicationYear}, Author: {book.Author}, ISBN: {book.Isbn}");
        }
    }


    class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
    }
}



