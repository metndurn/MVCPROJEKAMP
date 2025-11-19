using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
	public class Context : DbContext //entity frameworkun dbcontext sınıfına ihtiyacımız var yazdıgımız dbsetler entitylayerdaki classlarla baglantı kuracak ve veritabanında tabloları olusturacak
	{
		public DbSet<About> Abouts { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Content> Contents { get; set; }
		public DbSet<Heading> Headings { get; set; }
		public DbSet<Writer> Writers { get; set; }
	}
}
