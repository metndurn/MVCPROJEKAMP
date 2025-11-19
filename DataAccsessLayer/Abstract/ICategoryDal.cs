using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
	public interface ICategoryDal //Category Data Access Layer interface 
	{
		//CRUD OPERASYONLARI İÇİN METOTLAR
		List<Category> List();
		void Insert(Category category);
		void Update(Category category);
		void Delete(Category category);
	}
}
