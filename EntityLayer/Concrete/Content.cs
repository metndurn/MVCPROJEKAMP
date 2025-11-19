using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Content
	{
		[Key]
		public int ContentId { get; set; }

		[StringLength(1000)]
		public string ContentValue { get; set; }
		public DateTime ContentDate { get; set; }

		//ilişkiler bire çok oldugu ıcın buraya 2 tane nesne tanımlayacag��z yani bir baslıgın birden fazla ıcerıgı olabilir
		public int HeadindId { get; set; }
		public virtual Heading Heading { get; set; }

		//bir yazarın birden fazla ıcerıgı olabilir 
		public int WriterId { get; set; }
		public virtual Writer Writer { get; set; }
	}
}
