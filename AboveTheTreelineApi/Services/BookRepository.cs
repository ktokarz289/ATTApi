using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AboveTheTreelineApi.Models;

namespace AboveTheTreelineApi.Services
{
	public class BookRepository
	{
		public Book[] GetAllBooks()
		{
			return new Book[]
			{
				new Book
				{
					Id = 1,
					Title = @"From Good to Great",
					Description = @"A case study on how some companies make the leap and others don't",
					Rating = 4.5f,
					Author = @"Jim Collins"
				},

				new Book
				{
					Id = 2,
					Title = @"Steve Jobs",
					Description = @"A biography on Steve Jobs",
					Rating = 5.0f,
					Author = @"Walter Isaacson"
				},

				new Book
				{
					Id = 2,
					Title = @"Disrupted",
					Description = @"A tell all tale about a man's journey in a new age company",
					Rating = 3.5f,
					Author = @"Dan Lyons"
				}

			};
		}
	}
}