using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstModelProject.Models
{


	public class Movie
	{
		public int ID { get; set; }
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[DisplayName("Date of release")]

		public DateTime ReleaseDate { get; set; }
		public string Genre { get; set; }
		public decimal Price { get; set; }
		public decimal PriceRon { get; set; }
		

	}
}