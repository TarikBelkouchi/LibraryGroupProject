// See https://aka.ms/new-console-template for more information
using GroupProjectLibrary;

Console.WriteLine("Hello, World!");


Library library = new Library();

//library.DisplayAllBooks();

Console.WriteLine();


static void showTitle(List<Book> titles)
{
	foreach (Book b in titles)
	{
		Console.WriteLine(b.Title);
	}


}
