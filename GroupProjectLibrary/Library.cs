using System;
namespace GroupProjectLibrary
{
	public class Library
	{
		public List<Book> books = new List<Book>()
		{
			new Book ("The Prophet", "Kahlil Gibran", true),
			new Book ("The Midnight Library", "Matt Haig", false),
			new Book ("Black Cake", "Charmaine Wilkerson", false),
			new Book ("The Maid", "Nita Prose", true),
			new Book ("The Lincoln Highway", "Amor Towles", true),
			new Book ("The Christie Affair", "Nina De Gramont", true),
			new Book ("The Last Thing He Told Me", "Laura Dave", false),
			new Book ("The Judge's List", "John Grisham", false),
			new Book ("Harry Potter and the Chamber of Secrets", "J.K Rowling", true),
			new Book ("The Hobbit", "J.R. Tolkein", true),
			new Book ("It", "Stephen King", false),
			new Book ("To the Lighthouse", "Virginia Wolfe", false),
			new Book ("The Lovely Bones", "Alice Sebold", true)
		};


		//      public void DisplayAllBooks()
		//{
		//	foreach (Book b in book)
		//	{
		//              //Console.WriteLine($"{b.Title}, \t {b.Author}, \t Checked out: {b.Status} \t Return Date: {b.DueDate}");
		//              Console.WriteLine(b.ToString());
		//	}

		//}

		public void showTitle(List<Book> books)
		{
			foreach (Book b in books)
			{
				Console.WriteLine(b.Title);
			}
		}


	}
}





//new Book ("The Prophet", "Kahlil Gibran", true, DateTime.Parse("01/03/22")),
//new Book ("The Midnight Library", "Matt Haig", false, DateTime.Parse("")),
//new Book ("Black Cake", "Charmaine Wilkerson", false, DateTime.Parse("")),
//new Book ("The Maid", "Nita Prose", true, DateTime.Parse("12/31/22")),
//new Book ("The Lincoln Highway", "Amor Towles", true, DateTime.Parse("4/5/22")),
//new Book ("The Christie Affair", "Nina De Gramont", true, DateTime.Parse("12/31/22")),
//new Book ("The Last Thing He Told Me", "Laura Dave", false, DateTime.Parse("")),
//new Book ("The Judge's List", "John Grisham", false, DateTime.Parse("")),
//new Book ("Harry Potter and the Chamber of Secrets", "J.K Rowling", true, DateTime.Parse("6/21/22")),
//new Book ("The Hobbit", "J.R. Tolkein", true, DateTime.Parse("5/5/22")),
//new Book ("It", "Stephen King", false, DateTime.Parse("")),
//new Book ("To the Lighthouse", "Virginia Wolfe", false, DateTime.Parse("")),
//new Book ("The Lovely Bones", "Alice Sebold", true, DateTime.Parse("12/31/22")),
