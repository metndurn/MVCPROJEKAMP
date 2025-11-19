using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }

		[StringLength(50)]
		public string CategoryName { get; set; }

		[StringLength(200)]	
		public string CategoryDescription { get; set; }
		public string CategoryStatus { get; set; }

		//ilişkiler bire çok oldugu ıcın buraya collection tanımlıyoruz
		public ICollection<Heading> Headings { get; set; }//bire çok ilişki kuruldu yani bir kategorinin birden fazla baslaigi olabilir demektir
	}
}
