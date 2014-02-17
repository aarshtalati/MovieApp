using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevChallenge.Models;
using System.Text;

namespace DevChallenge.Controllers
{
	public class MoviesController : Controller
	{
		//
		// GET: /Movies/
		TitlesContext db = new TitlesContext();
		public ActionResult Index()
		{
			var genres = db.Genres.ToList();
			return View(genres);
		}

		//
		// GET: /Movies/Browse
		// GET: /Movies/Browse/Sports
		// GET: /Movies/Browse?id=Sports
		public ActionResult Browse(string id)
		{
			//string message = HttpUtility.HtmlEncode(string.Format("Store.Browse, Genre = {0}", id));
			//return message;
			ViewBag.SelectedGenre = id;
			var genreCollection = from t in db.Titles
								  join tg in db.TitleGenres on t.TitleId equals tg.TitleId
								  join g in db.Genres on tg.GenreId equals g.Id
								  where g.Name == id
								  select t;
			return View(genreCollection);
		}

		//
		// GET: /Movies/Details
		// GET: /Movies/Details/5
		// GET: /Movies/Details?id=5
		public ActionResult Details(Nullable<int> id = -1)
		{
			var movie = db.Titles.FirstOrDefault(t => t.TitleId.Equals(id.Value));
			return View(movie);
		}

		public ActionResult CrewMembers(Nullable<int> id = -1)
		{
			var crew = from member in db.Participants
					   join tp in db.TitleParticipants.Where(tp => tp.TitleId == id) on member.Id equals tp.ParticipantId
					   where tp.TitleId == id.Value
					   select member;
			return View(crew);
		}
	}
}
