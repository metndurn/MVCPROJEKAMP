using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccsessLayer.Concrete.Repositories
{
	/*burada ilk basta olusturmus oldugumuz interfacelerin butun komutlarını burada yazıyoruz
	 yanı ınterface ısım alanı burada ıse Repository tarafında kodlar yazılır*/
	public class CategoryRepository : ICategoryDal
	{
		Context Context = new Context();
		DbSet<Category> _object;

		public void Delete(Category category)
		{
			_object.Remove(category);
			Context.SaveChanges();
		}

		public void Insert(Category category)
		{
			_object.Add(category);
			Context.SaveChanges();
		}

		public List<Category> List()
		{
			return _object.ToList();
		}

		public List<Category> List(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public void Update(Category category)
		{
			Context.SaveChanges();
		}
	}
}
