using DataAccsessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CategoryManager
	{
		GenericRepository<Category> repoCategory = new GenericRepository<Category>();//burada category repositoryden bir nesne türettik

		//her bır crud ıslemı ıcın metodlar yazıyoruz
		public List<Category> GetAllBL()//tüm kategorileri listeleme metodu
		{
			return repoCategory.List();
		}
		public void CategoryAddBL(Category category)//kategori ekleme metodu
		{
			/*burada ki kosulda herhangı bır hata gelırse kod hatası olarak eklenme me uyarısı verılecek*/
			if (category.CategoryName == "" || category.CategoryName.Length <= 3 ||
				category.CategoryDescription == "" || category.CategoryName.Length > 51)
			{
				//hata mesajı
			}
			else
			{
				repoCategory.Insert(category);
			}

	}
}
