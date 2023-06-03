using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Search(string query, int page)
        {
            return View();
        }
        [Route("/blog/title-slug")]
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}