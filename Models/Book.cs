﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibApp.Models
{
    public class Book
    {
        public int Id { get; set; }

		[Required(ErrorMessage = "Name required")]
		[StringLength(255)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string AuthorName { get; set; }

		public Genre Genre { get; set; }

		public byte GenreId { get; set; }

		public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Date is required")]
		public DateTime ReleaseDate { get; set; }

		[Required(ErrorMessage = "stocks are required")]
		[Range(1,20, ErrorMessage = "Price must be between 1 and 20")]
		public int NumberInStock { get; set; }

		[Required]
		public int NumberAvailable { get; set; }
	}
      
}
