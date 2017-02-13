using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogSite.Models;

namespace BlogSite.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        BContext db = new BContext();

        // accинхронный метод
        //public async Task<ActionResult> Index()
        //{
        //    // получаем из бд все объекты Category
        //    IEnumerable<Category> cats = await db.Category.ToListAsync();
        //    // передаем все объекты в динамическое свойство Cats в ViewBag
        //    ViewBag.Cats = cats;
        //    // возвращаем представление
        //    return View();
        //}

        //не ассинхронный метод
        public ActionResult Index()
        {
            //получаем из бд все объекты Category
            IEnumerable<Category> cats = db.Category.ToList();
            //передаем все объекты в динамическое свойство Cats в ViewBag
            ViewBag.Cats = cats;
            //возвращаем представление
            return View();
        }


        [HttpGet]
        public ActionResult AddCat()
        {
            return View();
        }


        [HttpPost]
        public string AddCat(Category cat)
        {

            foreach (var categ in db.Category)
            {
                //При попытке создания существующей категории система выдает ошибку и отменяет операцию Email не отсылается. 
                if (categ.catName.Equals(cat.catName))
                {
                    return "Категория уже существует!";
                }
            }
            //иначе 
            ///
            //реализация отправки на почту модератору
            ///

            //добавление категориии в бд
            db.Category.Add(cat);
            db.SaveChanges();
            return "Категория добавлена!";
        }



    }
}