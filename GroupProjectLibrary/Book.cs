﻿using System;
namespace GroupProjectLibrary
{
	public class Book
	{
		public string Title { get; set; }
		public string Author { get; set; }
		public bool Status { get; set; }
		public DateTime? DueDate { get; set; } //'?' is for making many Data types nullable

		//checked out
		public Book(string _title, string _author, bool _status, DateTime _duedate)
		{
			Title = _title;
			Author = _author;
			Status = _status;
			DueDate = _duedate;
		}

        //on shelf
        public Book(string _title, string _author, bool _status)
        {
            Title = _title;
            Author = _author;
            Status = _status;
            DueDate = null;
        }

    }
}

