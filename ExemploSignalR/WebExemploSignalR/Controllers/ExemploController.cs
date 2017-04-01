using System.Web.Mvc;

namespace WebExemploSignalR.Controllers
{
    public class ExemploController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}