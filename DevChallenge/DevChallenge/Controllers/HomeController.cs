using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevChallenge.Models;

namespace DevChallenge.Controllers
{
	public class HomeController : Controller
	{
		TitlesContext db = new TitlesContext();
		//
		// GET: /Home/
		public ActionResult Index()
		{
			return View();
		}
		public JsonResult Latest(int id)
		{
			var topN = (from t in db.Titles
						select t).Take(5);
			return Json((from obj in topN select new { Id = obj.TitleId, Name = obj.TitleName }), JsonRequestBehavior.AllowGet);
		}
	}
}
