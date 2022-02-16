using System;
namespace GroupProjectLibrary
{
	internal class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public bool Status { get; set; }
		public double DueDate { get; set; }

		public Book(string _title, string _author, bool _status, double _duedate)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = _duedate;

		}
	}
}

