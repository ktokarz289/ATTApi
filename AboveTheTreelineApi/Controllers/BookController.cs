using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AboveTheTreelineApi.Models;
using AboveTheTreelineApi.Services;

namespace AboveTheTreelineApi.Controllers
{
    public class BookController : ApiController
    {
		private BookRepository bookRepository;

		public BookController()
		{
			bookRepository = new BookRepository();
		}

		public Book[] Get()
		{
			return bookRepository.GetAllBooks();
		}
    }
}
