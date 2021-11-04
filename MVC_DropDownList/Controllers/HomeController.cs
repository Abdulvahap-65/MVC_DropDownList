using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_DropDownList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            int kategoriID = 2;
            List<SelectListItem> kategoriler = new List<SelectListItem>();
            foreach (var item in db.Categories.ToList())
            { 
                kategoriler.Add(
                    new SelectListItem {
                        Text = item.CategoryName,
                        Value = item.CategoryID.ToString(),                    
                        Selected = (item.CategoryID == kategoriID ? true : false),
                    });
            }
            ViewBag.Kategoriler = kategoriler;
            return View();
        }

        public ActionResult Calisma()
        {
            return View();
        }
    }
}