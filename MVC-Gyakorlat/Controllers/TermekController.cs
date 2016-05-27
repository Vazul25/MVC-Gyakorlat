using BLL;
using MVC_Gyakorlat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Gyakorlat.Controllers
{
    public class TermekController : Controller
    {
        // GET: Termek
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Search()
        {
            TermekSearchModel m = new TermekSearchModel()
            {
                TermekNev = "a",
                MinAr = 1
            };
            return View(m);

        }
        [HttpPost]
        public ActionResult Search(TermekSearchModel m)
        {
            ViewBag.SearchCondition = m;
            if (ModelState.IsValid)
            {
                return View("SearchResult",
                    TermekSearchResultModel.EnumerateTermek(
                        TermekManager.Search(m.TermekNev, m.MinAr)));
            }
            else return View(m);
        }
    }
}