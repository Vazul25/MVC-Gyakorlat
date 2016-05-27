using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using MVC_Gyakorlat.Models;

namespace MVC_Gyakorlat.Controllers
{
    public class MegrendelesController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public ActionResult Search()
        {
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            dtfi.ShortDatePattern = "yyyy-MM-dd";
            dtfi.DateSeparator = ".";
            MegrendelesSearchModel m = new MegrendelesSearchModel
            {
                VevoNev = "n",
                FromDate = DateTime.Parse("2000.01.01", dtfi),
                ToDate = DateTime.Today
            };
            return View(m);
        }

        [HttpPost]
        public ActionResult Search(MegrendelesSearchModel m)
        {
            ViewBag.SearchCondition = m;
            return View("SearchResult",
                        MegrendlesSearchResultModel.Enumerate(MegrendelesManager.Search(m.VevoNev, m.FromDate, m.ToDate)));

        }

        public ActionResult Details(int id)
        {
            return PartialView(MegrendlesTetelModel.Enumerate(MegrendelesManager.ListTetel(id)));
        }
    }
}