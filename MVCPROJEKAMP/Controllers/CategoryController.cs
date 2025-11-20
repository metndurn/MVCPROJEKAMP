using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPROJEKAMP.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager CategoryManager = new CategoryManager();
		public ActionResult Index()
        {
            return View();
        }
		public ActionResult GetCategoryList()//kategori listeleme işlemi
		{
			var categoryvalues = CategoryManager.GetAllBL();//tüm kategorileri getir
			return View(categoryvalues);
		}
	}
}