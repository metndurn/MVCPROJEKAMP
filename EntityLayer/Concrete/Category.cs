using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Category
	{
		public int Id { get; set; }
		public string CategryName { get; set; }
		public string CategoryDescription { get; set; }
		public string CategoryStatus { get; set; }
	}
}
