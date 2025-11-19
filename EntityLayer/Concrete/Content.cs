using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Content
	{
		public int Id { get; set; }
		public string ContentValue { get; set; }
		public DateTime ContentDate { get; set; }
		//ContentYazar ilişkili olacagı ıcın bunlar olacak yanı bu yazı kım tarafından yazıldıgını belırtecegız
		//ContentBaslik ılıskısı ıcınde bunlar olacak yanı bu yazı hangi baslıga aıt oldugunu belırtecegız
	}
}
