using Microsoft.AspNetCore.Mvc;

namespace dojosurvey
{
    public class MainController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost]
        [Route("result")]
        public IActionResult Result(string name, string fav, string location, string comment)
        {
            ViewBag.Name = name;
            ViewBag.Fav = fav;
            ViewBag.Location = location;
            ViewBag.Comment = comment;
            return View("result");
        }
    }
}