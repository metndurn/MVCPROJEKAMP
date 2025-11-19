using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Heading
	{
		public int HeadingId { get; set; }
		public string HeadingName { get; set; }
		public DateTime HeadingDate { get; set; }

		//ilişkiler bire çok oldugu ıcın buraya 2 tane nesne tanımlayacagız yani bir kategorinin birden fazla baslıgı olabilir
		public int CategoryId { get; set; }
		public virtual Category Category { get; set; }


		//bir yazarın birden fazla baslıgı olabilir
		public int WriterId { get; set; }
		public virtual Writer Writer { get; set; }

		public ICollection<Content> Contents { get; set; }//bire çok ilişki kuruldu yani bir baslıgın birden fazla ıcerıgı olabilir demektir
	}
}
