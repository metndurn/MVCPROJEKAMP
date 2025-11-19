using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Writer
	{
		public int WriterId { get; set; }
		public string WtierName { get; set; }
		public string WriterSurname { get; set; }
		public string WriterImage { get; set; }
		public string WriterMail { get; set; }
		public string WriterPassword { get; set; }

		public ICollection<Heading> Headings { get; set; }//bir yazarın birden fazla baslıgı olabilir demektir
		public ICollection<Content> Contents { get; set; }//bir yazarın birden fazla ıcerıgı olabilir demektir
	}
}
