using Microsoft.AspNetCore.Mvc;

namespace AspNetMvc.Controllers
{
    public class PageController : Controller
    {
        [Route("/page/title-slug")]
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}