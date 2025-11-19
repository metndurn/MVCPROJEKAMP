using DataAccsessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Repositories
{
	public class GenericRepository<T> : IRepository<T> where T : class
	{
		Context Context = new Context();
		DbSet<T> _object;
		public GenericRepository()//constructor metodu 
		{
			_object = Context.Set<T>();//hangi tipte bir nesne gelirse gelsin contextden o nesneye ait dbseti alır
		}

		public void Delete(T t)
		{
			_object.Remove(t);
			Context.SaveChanges();
		}

		public void Insert(T t)
		{
			_object.Add(t);
			Context.SaveChanges();
		}

		public List<T> List()
		{
			return _object.ToList();
		}

		public List<T> List(Expression<Func<T, bool>> filter)
		{
			return _object.Where(filter).ToList();
		}

		public void Update(T t)
		{
			Context.SaveChanges();
		}
	}
}
