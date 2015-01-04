using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
	public class AboutController : Controller
	{
		public ActionResult Index()
		{
			var about = new List<string>();
			about.Add("This is a sample movie app written in Pure MVC 4, .NET 4 and LINQ to SQL, HTML5 and CSS3 under less than 3 Hrs.");
			about.Add("Due to some issues, the application and database are being hosted on separate providers, which I think is the reason why the app takes some considerable amount of time to kick start :-/");
			about.Add("On the home page you'd see 5 most recent movies, alternatively if you click on movies you'd see a list of genres and movies could be further drilled down by clicking on genres.");
			about.Add("Once you're on the movie screen, you can also see the full list of crews by clicking the \"[More]\" in orange.");
			about.Add("You can also notice the \"Context Search\" which searches on the current page on the client side.");
			about.Add("GitHub Repository : https://github.com/ablaze8/movieapp");
			return View(about);
		}
	}
}