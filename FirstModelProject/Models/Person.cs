using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstModelProject.Models
{
	public class Person
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		[Range (0,150)]
		public int Age { get; set; }
		public string Sex { get; set; }



	}

	public enum Gender
	{
		M,
		F,
		NA
	}
}