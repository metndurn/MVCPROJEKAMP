using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Writer
	{
		public int Id { get; set; }
		public string WtierName { get; set; }
		public string WriterSurname { get; set; }
		public string WriterImage { get; set; }
		public string WriterMail { get; set; }
		public string WriterPassword { get; set; }
	}
}
