﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AboveTheTreelineApi.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public float Rating { get; set; }
		public string Author { get; set; }
	}
}